using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using System.Xml.Linq;

namespace ReadIcqHistory
{
    public partial class Form1 : Form
    {
        private List<IcqMessage> _messages;
        private Dictionary<int, string> _icqToSpark = new Dictionary<int, string>();
        private Dictionary<string, int> _sparkToIcq = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
            foreach (string key in System.Configuration.ConfigurationSettings.AppSettings.AllKeys)
            {
                int uin;
                if (int.TryParse(key, out uin))
                {
                    string sparkUsr = System.Configuration.ConfigurationSettings.AppSettings[key];
                    _icqToSpark.Add(uin, sparkUsr);
                    _sparkToIcq.Add(sparkUsr, uin);
                }
            }
        }

        private void btnSelectDateFile_Click(object sender, EventArgs e)
        {
            dlgOpenDataFile.ShowDialog();
            txtDataFile.Text = dlgOpenDataFile.FileName;
            btnDoIt.Enabled = true;
        }

        private void btnDoIt_Click(object sender, EventArgs e)
        {
            //Read ICQ history
            FileStream dataStream = File.OpenRead(txtDataFile.Text);
            _messages = new List<IcqMessage>();
            while (dataStream.Position < dataStream.Length)
            {
                ReadNextMessage(_messages, dataStream);
            }
            progressBar.Value = 25;
            progressBar.Update();

            //MessageBox.Show(
            //    "Messages read: " + _messages.Count.ToString() + "\r\n" +
            //    "First message: " + _messages[0].Timestamp.ToString() + "\r\n" +
            //    "Last message: " + _messages[_messages.Count - 1].Timestamp.ToString());

            //Read spark history
            List<SparkMessage> _sparkMessages = new List<SparkMessage>();
            foreach (string filePath in System.IO.Directory.GetFiles(
                txtFolderTranscripts.Text, "*@openfire.lan-hoev.twinfield.com.xml"))
            {
                XmlDocument transcript = new XmlDocument();
                transcript.Load(filePath);

                foreach (XmlElement msg in transcript.DocumentElement.SelectNodes("messages/message"))
                {
                    _sparkMessages.Add(new SparkMessage(msg));
                }
            }
            progressBar.Value = 50;
            progressBar.Update();

            string backupCounter = String.Empty;
            string backupFolder = Path.Combine(txtFolderTranscripts.Text, string.Format("Backup{0}", backupCounter));
            backupCounter = "0";
            while (Directory.Exists(backupFolder))
            {
                backupCounter = (int.Parse(backupCounter) + 1).ToString();
                backupFolder = Path.Combine(txtFolderTranscripts.Text, string.Format("Backup{0}", backupCounter));
            }
            Directory.CreateDirectory(backupFolder);

            string currentUser = Path.GetFileName(Path.GetDirectoryName(txtFolderTranscripts.Text));
            currentUser = currentUser.Remove(currentUser.IndexOf('@'));

            // Move files from users present in the icq to spark mapping to the backup folder
            // current and history
            foreach (string file in Directory.GetFiles(txtFolderTranscripts.Text))
            {
                bool moveFile = true;

                string fileName = Path.GetFileName(file);
                if (fileName.Contains("@openfire."))
                {
                    string sparkUser = fileName.Substring(0, fileName.IndexOf('@'));

                    moveFile =
                        (from usr in _icqToSpark.Values
                         where usr == sparkUser
                         select usr).Count() > 0;
                }
                if (moveFile) File.Move(file, Path.Combine(backupFolder, Path.GetFileName(file)));
            }
            
            XmlDocument conversations = new XmlDocument();
            conversations.AppendChild(conversations.CreateElement("conversations"));

            // Combine history files
            int total = _icqToSpark.Count;
            int walker = 0;
            int totalCount = 0;
            foreach (KeyValuePair<int, string> kvp in _icqToSpark)
            {
                if (kvp.Value == currentUser) continue;
                walker++;
                IOrderedEnumerable<SparkMessage> allMessages =
                    from msg in
                        (
                            from icqMsg in _messages
                            where icqMsg.Uin == kvp.Key
                            select new SparkMessage(
                                _icqToSpark[icqMsg.Direction == MessageDirection.Received ? icqMsg.Uin : 1008],
                                _icqToSpark[icqMsg.Direction == MessageDirection.Sent ? icqMsg.Uin : 1008],
                                icqMsg.Timestamp,
                                icqMsg.PlainText)
                        ).Concat(
                            from sprkMsg in _sparkMessages
                            where sprkMsg.From == kvp.Value
                                || sprkMsg.To == kvp.Value
                            select sprkMsg
                        )
                    orderby msg.TimeStamp
                    select msg;

                int currentCount = allMessages.Count();
                if (currentCount > 0)
                {
                    totalCount += currentCount;
                    lblMsgCounter.Text = totalCount.ToString();
                    lblMsgCounter.Update();

                    string sparkUser = kvp.Value + "@openfire.lan-hoev.twinfield.com";
                    conversations.DocumentElement.AppendChild(conversations.CreateElement("user")).InnerText = sparkUser;

                    WriteAllMessages(allMessages, sparkUser, sparkUser + ".xml");
                    WriteAllMessages(allMessages.Skip(allMessages.Count() - 20), sparkUser, sparkUser + "_current.xml");
                }
                progressBar.Value = 50 + ((walker / total) * 50);
                progressBar.Update();
            }

            conversations.Save(Path.Combine(txtFolderTranscripts.Text, "conversations.xml"));
        }

        private void WriteAllMessages(IEnumerable<SparkMessage> allMessages, string sparkUser, string fileName)
        {

            XmlDocument userHistory = new XmlDocument();
            XmlElement xmlTranscript = (XmlElement)userHistory.AppendChild(userHistory.CreateElement("transcript"));
            XmlElement xmlMessages = (XmlElement)xmlTranscript.AppendChild(userHistory.CreateElement("messages"));

            foreach (SparkMessage msg in allMessages)
            {
                XmlElement xmlMessage = (XmlElement)xmlMessages.AppendChild(userHistory.CreateElement("message"));
                xmlMessage.AppendChild(userHistory.CreateElement("to")).InnerText = msg.To + "@openfire.lan-hoev.twinfield.com";
                xmlMessage.AppendChild(userHistory.CreateElement("from")).InnerText = msg.From + "@openfire.lan-hoev.twinfield.com";
                xmlMessage.AppendChild(userHistory.CreateElement("body")).InnerText = msg.Text;
                xmlMessage.AppendChild(userHistory.CreateElement("date")).InnerText = msg.TimeStamp.ToString("yyyy-MM-dd hh:mm:ss.fff") + " CET";
            }

            userHistory.Save(Path.Combine(txtFolderTranscripts.Text, fileName));

            //XElement xml =
            //    new XElement("transcript",
            //        new XElement("messages",
            //            from msg in allMessages
            //            select new XElement("message",
            //                new XElement("to", msg.To + "@openfire.lan-hoev.twinfield.com"),
            //                new XElement("from", msg.From + "@openfire.lan-hoev.twinfield.com"),
            //                new XElement("body", msg.Text),
            //                new XElement("date", msg.TimeStamp.ToString("yyyy-MM-dd hh:mm:ss.fff") + " CET"))));

            //xml.Save(Path.Combine(txtFolderTranscripts.Text, fileName), SaveOptions.None);
        }



        private bool ReadNextMessage(List<IcqMessage> messages, System.IO.FileStream dataStream)
        {
            try
            {
                messages.Add(new IcqMessage(dataStream));
                return true;
            }
            catch
            {
                return false;
            }

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            //SparkWriter writer = new SparkWriter(this);

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dlgOpenFolder.SelectedPath = txtFolderTranscripts.Text;
            dlgOpenFolder.ShowDialog();
            txtFolderTranscripts.Text = dlgOpenFolder.SelectedPath;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string folder = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), @"ICQCorp\DB");
            string[] subItems;
            if (Directory.Exists(folder))
            {
                subItems = System.IO.Directory.GetFiles(folder, "*msg.dat");

                if (subItems.Length == 1)
                {
                    txtDataFile.Text = subItems[0];
                }
                else
                {
                    txtDataFile.Text = folder;
                }
            }

            folder = Path.GetFullPath(Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal), @"..\Spark\user"));
            subItems = Directory.GetDirectories(folder);
            if (subItems.Length == 1)
            {
                folder = subItems[0] + "\\transcripts";
            }
            txtFolderTranscripts.Text = folder;
        }
    }
}
