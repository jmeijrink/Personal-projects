using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace ReadIcqHistory
{
    class SparkMessage
    {
        public string From;
        public string To;
        public DateTime TimeStamp;
        public string Text;

        public SparkMessage(XmlElement message)
        {
            From = StripAfterAt(message.SelectSingleNode("from").InnerText);
            To = StripAfterAt(message.SelectSingleNode("to").InnerText);
            TimeStamp = DateTime.Parse(message.SelectSingleNode("date").InnerText.Substring(0,19));
            Text = message.SelectSingleNode("body").InnerText;
        }

        public SparkMessage(
            string from,
            string to,
            DateTime timeStamp,
            string text)
        {
            From = from;
            To = to;
            TimeStamp = timeStamp;
            Text = text;
        }

        private string StripAfterAt(string userCode)
        {
            int at = userCode.IndexOf('@');
            if (at == -1)
            {
                return userCode;
            }
            else
            {
                return userCode.Remove(at);
            }
        }
    }
}
