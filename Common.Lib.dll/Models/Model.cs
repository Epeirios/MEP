using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Lib.Interfaces;
using System.Data.OleDb;

namespace Common.Lib.Models
{
    class Model : IModel
    {
        public DataSet GetJobData(string filename)
        {
            string connectionString =”Provider = Microsoft.Jet.OLEDB.4.0; Data Source = c:\csvfiles\; Extended Properties =’text; HDR = Yes'”;

            string commandText = string.Format(“Select * from { 0}”, filename);

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
