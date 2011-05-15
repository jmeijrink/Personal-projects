using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadIcqHistory
{
    internal class SparkWriter
    {
        private const string UINToUserXmlFilePath = ".";
        private readonly Form1 _ownerWindow;
        private Dictionary<string, SortedDictionary<DateTime, SparkMessage>> _userMessages = 
            new Dictionary<string, SortedDictionary<DateTime, SparkMessage>>();

        private class SparkMessage
        {
            public string From;
            public string To;
            public DateTime TimeStamp;
            public string Message;
        }

        public SparkWriter(Form1 owner)
        {
            _ownerWindow = owner;
        }

        public void WriteMessage(Message msg)
        {
            string contraParty = System.Configuration.ConfigurationSettings.AppSettings[msg.Uin.ToString()];
            System.Xml.XmlDocument sparkXml = GetHistoryXMLFile(contraParty);

            SparkMessage sprkMsg = new SparkMessage();
            if (msg.Direction == MessageDirection.Received)
            {
                sprkMsg.From = contraParty;
                sprkMsg.To = "";
            }
            else
            {
                sprkMsg.From = "";
                sprkMsg.To = contraParty;
            }

            sprkMsg.TimeStamp = msg.Timestamp;

            switch (msg.Type)
            {
                case MessageType.Text:
                    sprkMsg.Message = msg.Text;
                    break;
                case MessageType.Url:
                    sprkMsg.Message = msg.Text + ": " + msg.Url;
                    break;
                case MessageType.Application:
                    sprkMsg.Message = (msg.Text.Length == 0 ? "Multi-user application started" : msg.Text) + ": " + msg.Application;
                    break;
                case MessageType.UserInfo:
                    sprkMsg.Message = string.Format("User added: {0}\r\nFirst name: {1}\r\nLast name: {2}\r\ne-Mail: {3}", msg.NickName, msg.FirstName, msg.LastName, msg.eMail);
                    break;
                case MessageType.Unknown1:
                    sprkMsg.Message = msg.Text;
                    break;
                default:
                    throw new Exception("Type not implemented.");
            }

        }

        public void CloseWriter()
        {

        }

        private System.Xml.XmlDocument GetHistoryXMLFile(string sparkUser)
        {
            System.Xml.XmlDocument xmlDoc;
            if (!_userMessages.TryGetValue(sparkUser, out xmlDoc))
            {
                xmlDoc.Load(_ownerWindow.txtFolderTranscripts.Text);
                _userMessages.Add(sparkUser, xmlDoc);
            }
            return xmlDoc;
        }
    }
}
