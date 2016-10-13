using System;
using System.Collections.Generic;

namespace MEP
{
    class EppMessage
    {
        private string _messageType;
        private Dictionary<string, byte[]> _blocks =
            new Dictionary<string, byte[]>();

        public EppMessage(string messageType)
        {
            this._messageType = messageType;
        }

        public byte[] this[string key]
        {
            get { return _blocks[key]; }
            set { _blocks[key] = value; }
        }

        public void ShowMessage()
        {
            Console.WriteLine("Message Type: \t{0}", _messageType);
            Console.WriteLine("Header: \t{0}", _blocks["header"].ToString());
            Console.WriteLine("ID: \t\t{0}", _blocks["id"].ToString());
            Console.WriteLine("DataLength: \t{0}", _blocks["dataLength"].ToString());
            Console.WriteLine("Data: \t\t{0}", _blocks["data"].ToString());
            Console.WriteLine("Data: \t\t{0}", _blocks["checksum"].ToString());
        }
    }
}