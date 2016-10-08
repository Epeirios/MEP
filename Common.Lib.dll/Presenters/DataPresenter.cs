using Common.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Lib.Presenters
{
    public class DataPresenter : Presenter<IMainView>
    {
        public DataPresenter(IMainView view) : base(view)
        {

        }

        public void Display(string filename)
        {
            if (View != null) View.CSVData = Model.GetData(filename);
        }
    }
}
