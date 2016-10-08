using Common.Lib.Interfaces;
using Common.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Lib.Presenters
{
    public class Presenter <T> where T : IBaseInterface
    {
        protected static IModel Model { get; private set; }
        protected T View { get; private set; }

        static Presenter()
        {
            Model = new Model();
        }

        public Presenter(T view)
        {
            View = view;
        }

    }
}
