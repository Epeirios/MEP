using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEP
{
    abstract class EppMessageBuilder
    {
        protected EppMessage eppMessage;

        public EppMessage EPPMessage
        {
            get { return eppMessage; }
        }

        public abstract void BuildHeader();
        public abstract void BuildId();
        public abstract void BuildDataLenght();
        public abstract void BuildData();
        public abstract void BuildChecksum();
    }
}
