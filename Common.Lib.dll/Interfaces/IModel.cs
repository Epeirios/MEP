using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Lib.Interfaces
{
    interface IModel : IBaseInterface
    {
        DataSet GetJobData (string filename);
    }
}
