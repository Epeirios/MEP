using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Lib.Interfaces;
using Common.Lib.Presenters;

namespace MEP
{
    public partial class MainForm : Form, IMainView
    {
        private DataPresenter _presenter;

        public MainForm()
        {
            InitializeComponent();

            _presenter = new DataPresenter(this);
            _presenter.Display("text.csv");
        }

        public DataSet CSVData
        {
            set
            {
                dataGridView1.DataSource = value.Tables[0];
            }
        }
    }
}
