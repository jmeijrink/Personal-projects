using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ReadIcqHistory
{
    public enum MessageType
    {
        Text = 1,
        Unknown1 = 2,
        FileTransfer = 3,
        Url = 4,
        Application = 10,
        UserInfo = 12
    }

    public enum MessageDirection
    {
        Sent = 0,
        Received = -1
    }

    public enum MessageCause
    {
        New = 0,
        Reply = 1,
        Unknown = 99
    }

    public class IcqMessage
    {
        MessageType _type;
        public Int16 Uin;
        public string UserCode;
        public String Text;
        MessageDirection _direction;
        public DateTime Timestamp;
        public String Url;
        public String FileName;
        public String FilePath;
        MessageCause _cause;
        public String NickName;
        public String FirstName;
        public String LastName;
        public String eMail;
        public String Application;

        public MessageType Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public MessageCause Cause
        {
            get
            {
                return _cause;
            }
            set
            {
                _cause = value;
            }
        }

        public MessageDirection Direction
        {
            get
            {
                return _direction;
            }
            set
            {
                _direction = value;
            }
        }

        public string PlainText
        {
            get
            {
                switch (Type)
                {
                    case MessageType.Text:
                        return this.Text;
                    
                    case MessageType.Url:
                        return  this.Text + ": " + this.Url;
                    
                    case MessageType.Application:
                        return  (this.Text.Length == 0 ? "Multi-user application started" : this.Text) + ": " + this.Application;
                    
                    case MessageType.UserInfo:
                        return  string.Format("User added: {0}\r\nFirst name: {1}\r\nLast name: {2}\r\ne-Mail: {3}", this.NickName, this.FirstName, this.LastName, this.eMail);

                    case MessageType.Unknown1:
                        return  this.Text;

                    case MessageType.FileTransfer:
                        return string.Format("Transfered file: {0}.", this.FileName);

                    default:
                        throw new Exception("Type not implemented.");
                }

            }
        }

        public IcqMessage(FileStream dataStream)
        {
            dataStream.Seek(2, SeekOrigin.Current);

            this.Type = (MessageType)ReadInt16(dataStream);
            this.Uin = ReadInt16(dataStream);

            dataStream.Seek(2, SeekOrigin.Current);

            int msgLength = ReadInt16(dataStream);

            //Heading
            switch (this.Type)
            {
                case MessageType.Text:
                    this.Text = ReadString(dataStream, msgLength);
                    break;

                case MessageType.Url:
                    string[] descrAndLink = ReadString(dataStream, msgLength).Split(new char[] { '\xFE' });
                    this.Text = descrAndLink[0];
                    this.Url = descrAndLink[1];
                    break;

                case MessageType.FileTransfer:
                    this.Text = ReadString(dataStream, msgLength);
                    break;

                case MessageType.UserInfo:
                    string[] userInfo = ReadString(dataStream, msgLength).Split(new char[] { '\xFE' });
                    this.NickName = userInfo[0];
                    this.FirstName = userInfo[1];
                    this.LastName = userInfo[2];
                    this.eMail = userInfo[3];
                    break;

                case MessageType.Unknown1:
                    this.Text = ReadString(dataStream, msgLength);
                    break;

                case MessageType.Application:
                    this.Text = ReadString(dataStream, msgLength);
                    break;

                default:
                    throw new Exception("Unknown message type!");
            }

            this.Direction = (MessageDirection)ReadInt32(dataStream);
            if (this.Direction == MessageDirection.Sent)
            {
                this.Cause = (MessageCause)ReadInt32(dataStream);
            }
            else
            {
                this.Cause = MessageCause.Unknown;
                dataStream.Seek(4, SeekOrigin.Current);
            }

            dataStream.Seek(2, SeekOrigin.Current);

            this.Timestamp = ReadDate(dataStream);

            //Trailer
            switch (this.Type)
            {
                case MessageType.FileTransfer:
                    Int16 fileNameLength = ReadInt16(dataStream);
                    this.FileName = ReadString(dataStream, fileNameLength);

                    dataStream.Seek(4, SeekOrigin.Current);

                    Int16 filePathLength = ReadInt16(dataStream);
                    this.FilePath = ReadString(dataStream, filePathLength);

                    break;

                case MessageType.Unknown1:
                    this.Text = ReadString(dataStream, ReadInt16(dataStream));
                    break;

                case MessageType.Application:
                    this.Application = ReadString(dataStream, ReadInt16(dataStream));
                    dataStream.Seek(10, SeekOrigin.Current);
                    break;
            }
            // Skip last 4 unknown bytes.
            dataStream.Seek(4, SeekOrigin.Current);
        }

        private void SkipTwoBytes(FileStream dataStream)
        {
            dataStream.Seek(2, SeekOrigin.Current);
        }

        private Int16 ReadInt16(FileStream dataStream)
        {
            byte[] int16 = new byte[2];
            dataStream.Read(int16, 0, 2);
            return BitConverter.ToInt16(int16, 0);
        }

        private Int32 ReadInt32(FileStream dataStream)
        {
            byte[] int32 = new byte[4];
            dataStream.Read(int32, 0, 4);
            return BitConverter.ToInt32(int32, 0);
        }

        private string ReadString(FileStream dataStream, int textLength)
        {
            if (textLength == 0) return String.Empty;
            byte[] text = new byte[textLength];
            dataStream.Read(text, 0, textLength);
            return System.Text.Encoding.Default.GetString(text, 0, text.Length - 1);
        }

        private DateTime ReadDate(FileStream dataStream)
        {
            byte[] date = new byte[4];
            dataStream.Read(date, 0, 4);
            int dateValue = BitConverter.ToInt32(date, 0);

            return new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(dateValue);
        }
    }
}
