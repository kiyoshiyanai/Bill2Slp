using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bill2Slp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private DateTime GetPrefMonth(DateTime date)
        {
            return date.AddDays(-date.Day);
        }

        private string GetFileName()
        {
            string s = "";
            if (true)
            {

            }
            return s;
        }
    }
       
}
