using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HoursAccountability.Controls
{
    public partial class CodeNameFinder : UserControl
    {
        private string _finderCode = string.Empty;
        private Dictionary<string, string> _finderParams = new Dictionary<string, string>();
        private DateTime _lastKeyUp;
        private Timer _checkKeyUp;
        private TwinfieldFinder.FinderSoapClient _finder;
        private string _sessionId;

        public CodeNameFinder()
        {
            InitializeComponent();
        }

        public string SessionId
        {
            set
            {
               _sessionId = value;
            }
        }

        public string FinderCode
        {
            get
            {
                return _finderCode;
            }
            set
            {
                _finderCode = value;
            }
        }

        public Dictionary<string, string> FinderParams
        {
            get
            {
                return _finderParams;
            }
        }

        private void CodeNameFinder_Load(object sender, EventArgs e)
        {
            _checkKeyUp = new Timer();
            _checkKeyUp.Interval = 500;
            _checkKeyUp.Tick += new EventHandler(_checkKeyUp_Tick);

            _finder = new TwinfieldFinder.FinderSoapClient();
        }

        void _checkKeyUp_Tick(object sender, EventArgs e)
        {
            // Use finder to get project.
            _checkKeyUp.Stop();

            string[][] options = 
                (from kvp in _finderParams
                 select new string[] { kvp.Key, kvp.Value }).ToArray();

            TwinfieldFinder.FinderData data;
            _finder.Search(new TwinfieldFinder.Header() { SessionID = _sessionId }, "DIM", txtCode.Text, 0, 0, 9999, options, out data);

            
        
            throw new NotImplementedException();
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            _checkKeyUp.Enabled = false;
        }

        private void txtCode_KeyUp(object sender, KeyEventArgs e)
        {
            _lastKeyUp = DateTime.Now;
            _checkKeyUp.Start();
        }


    }
}
