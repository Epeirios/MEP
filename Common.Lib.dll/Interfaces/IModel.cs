﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Lib.Interfaces
{
    public interface IModel : IBaseInterface
    {
        DataSet GetData (string filename);
    }
}
