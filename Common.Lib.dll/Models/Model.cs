using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Lib.Interfaces;
using System.Data.OleDb;
using System.IO;

namespace Common.Lib.Models
{
    public class Model : IModel
    {
        public DataSet GetData(string filename)
        {



            string pathOnly = Path.GetDirectoryName(@"C:\bla\");

            string connectionString = string.Format("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = {0}; Extended Properties =\"Text; HDR = Yes\"", pathOnly);

            string commandText = string.Format("SELECT * FROM [{0}]", filename);

            OleDbConnection conn = new OleDbConnection(connectionString);

            OleDbCommand cmd = new OleDbCommand(commandText, conn);



            conn.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(commandText, conn);

            DataSet JobData = new DataSet();

            da.Fill(JobData);

            return JobData;
        }
    }
}
