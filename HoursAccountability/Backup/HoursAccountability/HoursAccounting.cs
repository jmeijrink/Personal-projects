using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace HoursAccountability
{
    public partial class HoursAccounting : Form
    {
        internal readonly static TwinfieldSession.SessionSoapClient TwfSession = new HoursAccountability.TwinfieldSession.SessionSoapClient();
        internal static string SessionId = null;
        private System.Threading.Timer _keepAlive = null;
        private System.Threading.TimerCallback _keepAliveCallback = null;

        private string _xmlFilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), 
            Path.Combine("HoursAccountability", "Hours.xml"));

        private class TimeProps
        {
            public System.Windows.Forms.ListViewItem ListItem;
            public TimeEntry Time;

            public TimeProps(ListViewItem listItem, TimeEntry time)
            {
                Time = time;
                ListItem = listItem;
            }
        }

        private Dictionary<TimeEntryKey, TimeProps> _hours = new Dictionary<TimeEntryKey, TimeProps>();
        private TimeProps _currentProject = null;

        public HoursAccounting()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            TimeEntryKey key;
            key.Day = DateTime.Today;
            key.Type = lstType.Text;
            key.Project = string.Empty; // txtProject.Text;
            key.Activity = string.Empty; // txtActivity.Text;

            if (!_hours.TryGetValue(key, out _currentProject))
            {
                _currentProject = new TimeProps(
                    new ListViewItem(new string[] { key.Day.ToShortDateString(), key.Type, key.Project, key.Activity, String.Empty }), 
                    new TimeEntry(key));
                _hours.Add(key, _currentProject);
                lvHours.Items.Add(_currentProject.ListItem);
            }

            btnStart.Enabled = false;
            btnPause.Enabled = true;
            _currentProject.Time.SecondElapsedEvent += new TimeEntry.SecondElapsedEventHandler(_currentProject_SecondElapsedEvent);
            _currentProject.Time.Start();
        }

        delegate void SetTimeCallback(TimeSpan elapsed);

        private void SetTime(TimeSpan elapsed)
        {
            if (lvHours.InvokeRequired)
            {
                SetTimeCallback d = new SetTimeCallback(SetTime);
                this.Invoke(d, new object[] { elapsed });
            }
            else
            {
                _currentProject.ListItem.SubItems[4].Text
                    = string.Format("{0}:{1:00}:{2:00}", elapsed.Hours, elapsed.Minutes, elapsed.Seconds);
                lvHours.Update();
            }
        }

        void _currentProject_SecondElapsedEvent(TimeEntry sender, TimeSpan elapsed)
        {
            SetTime(elapsed);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            _currentProject.Time.Stop();
            btnPause.Enabled = false;
            btnStart.Enabled = true;
        }

        private void lvHours_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_currentProject.Time.Running && lvHours.SelectedItems.Count == 1)
            {
                ListViewItem item = lvHours.SelectedItems[0];
                txtDate.Text = item.Text;
                lstType.Text = item.SubItems[1].Text;
                //txtProject.Text = item.SubItems[2].Text;
                //txtActivity.Text = item.SubItems[3].Text;
                txtTime.Text = item.SubItems[4].Text;
            }
        }

        private void HoursAccounting_Shown(object sender, EventArgs e)
        {
            // Start keep-alive timer
            _keepAliveCallback = new System.Threading.TimerCallback(KeepSessionAlive);
            _keepAlive = new System.Threading.Timer(_keepAliveCallback);
            _keepAlive.Change(600000, 600000);
        }

        private void KeepSessionAlive(object stateInfo)
        {
            TwfSession.KeepAlive(new HoursAccountability.TwinfieldSession.Header());
        }

        private void HoursAccounting_Load(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.ShowDialog();
            
            txtDate.Text = DateTime.Now.ToShortDateString();

            if (File.Exists(_xmlFilePath))
            {
                TextReader tr = null;
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(TimeEntry[]));
                    tr = new StreamReader(_xmlFilePath);
                    TimeEntry[] data = (TimeEntry[])serializer.Deserialize(tr);
                    foreach( TimeEntry time in data)
                    {
                        ListViewItem item = lvHours.Items.Add(new ListViewItem(new string[] { time.Key.Day.ToShortDateString(), time.Key.Type, time.Key.Project, time.Key.Activity, time.Duration.ToString() }));
                        _hours.Add(time.Key, new TimeProps(item, time));
                    }
                    
                }
                finally
                {
                    if (tr != null) tr.Close();
                }
            }
        }

        private void HoursAccounting_FormClosing(object sender, FormClosingEventArgs e)
        {
            TextWriter tw = null;
            try
            {
                TimeEntry[] data =
                    (from prop in _hours.Values
                     select prop.Time).ToArray();

                XmlSerializer serializer = new XmlSerializer(typeof(TimeEntry[]));
                tw = new StreamWriter(_xmlFilePath);
                serializer.Serialize(tw, data);
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                MessageBox.Show("Unable to save hours: " + ex.Message);
            }
            finally
            {
                if (tw != null) tw.Close(); 
            }
        }
    }
}
