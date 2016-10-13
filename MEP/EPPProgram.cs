using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace MEP
{
    public class EppProgram

    {

        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void EPPMain()
        {
            EppMessageBuilder builder;

            // Create shop with vehicle builders
            EppTestDirector director = new EppTestDirector();
            // Construct and display vehicles

            builder = new GetInfoBuilder();
            director.Construct(builder);
            builder.EPPMessage.ShowMessage();

            //builder = new GetInfoResponseBuilder();
            //director.Construct(builder);
            //builder.EPPMessage.ShowMessage();

            //builder = new ErrorBuilder();
            //director.Construct(builder);
            //builder.EPPMessage.ShowMessage();

            // Wait for user
            Console.ReadKey();
        }
    }
    


}
