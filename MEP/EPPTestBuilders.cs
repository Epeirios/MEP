using System;

namespace MEP
{
    class GetInfoBuilder : EppMessageBuilder
    {
        public GetInfoBuilder()
        {
            eppMessage = new EppMessage("Get Device Info");
        }

        public override void BuildChecksum()
        {
            byte[] temp = { 0x09 };
            eppMessage["checksum"] = temp;
        }

        public override void BuildData()
        {
            byte[] temp = { };
            eppMessage["data"] = temp;
        }

        public override void BuildDataLenght()
        {
            byte[] temp = { 0x00, 0x00 };
            eppMessage["dataLength"] = temp;
        }

        public override void BuildHeader()
        {
            byte[] temp = { 0x99 };
            eppMessage["header"] = temp;
        }

        public override void BuildId()
        {
            byte[] temp = { 0x70 };
            eppMessage["id"] = temp;
        }
    }
}