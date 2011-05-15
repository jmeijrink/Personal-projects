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
        private TwinfieldFinder.Finder _finder = new HoursAccountability.TwinfieldFinder.Finder();
        private bool _finderBusy = false;

        public CodeNameFinder()
        {
            InitializeComponent();
        }

        public string SessionId
        {
            set
            {
                _finder.HeaderValue = new HoursAccountability.TwinfieldFinder.Header() { SessionID = value };
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

        public string Code
        {
            get
            {
                return txtCode.Text;
            }
            set
            {
                txtCode.Text = value;
            }
        }

        
        public void SetFinderParam(string name, string value)
        {
            if (_finderParams.ContainsKey(name))
            {
                _finderParams[name] = value;
            }
            else
            {
                _finderParams.Add(name, value);
            }
        }

        private void CodeNameFinder_Load(object sender, EventArgs e)
        {
            _finder = new TwinfieldFinder.Finder();
            _finderParams.Add("section", "teq");
        }


        public void PopulateAutoComplete()
        {
            if (_finderBusy) return;
            txtCode.Enabled = false;
            progressBar1.Visible = true;

            string[][] options =
                (from kvp in _finderParams
                 select new string[] { kvp.Key, kvp.Value }).ToArray();

            _finder.SearchCompleted += new HoursAccountability.TwinfieldFinder.SearchCompletedEventHandler(_finder_SearchCompleted);
            _finderBusy = true;
            _finder.SearchAsync("DIM", "*", 1, 1, 9999, options);
        }

        void _finder_SearchCompleted(object sender, HoursAccountability.TwinfieldFinder.SearchCompletedEventArgs e)
        {
            _finderBusy = false;
            TwinfieldFinder.MessageOfErrorCodes[] messages = e.Result;
            if (messages.Length > 0)
            {
                foreach (TwinfieldFinder.MessageOfErrorCodes errorMsg in messages)
                {
                    System.Diagnostics.Debug.Print("Error: {0}", errorMsg.Text);
                }
            }
            else
            {
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                foreach (string[] row in e.data.Items)
                {
                    System.Diagnostics.Debug.Print(string.Format("{0} - {1}", row[0], row[1]));
                    col.Add(string.Format("{0} - {1}", row[0], row[1]));
                }
                txtCode.AutoCompleteCustomSource = col;
            }
            txtCode.Enabled = true;
            progressBar1.Visible = false;
        }

        public delegate void CodeChangedEventHandler(object sender, EventArgs e);
        public event CodeChangedEventHandler CodeChanged;
        private void txtCode_TextChanged(object sender, EventArgs e)
        {

            string value = txtCode.Text;
            int seperatorPos = value.IndexOf(" - ");
            if (seperatorPos != -1)
            {
                txtCode.Text = value.Substring(0, seperatorPos);
                txtName.Text = value.Substring(seperatorPos + 2);
            }
            if(CodeChanged != null) CodeChanged(this, new EventArgs());
        }
    }
}
