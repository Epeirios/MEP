using System;

namespace MEP
{
    class EppTestDirector
    {
        public void Construct(EppMessageBuilder builder)
        {
            builder.BuildHeader();
            builder.BuildId();
            builder.BuildDataLenght();
            builder.BuildData();
            builder.BuildChecksum();
        }
    }
}