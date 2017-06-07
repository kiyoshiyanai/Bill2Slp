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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                s = openFileDialog1.FileName;
            }
            return s;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = GetPrefMonth(DateTime.Today);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = GetPrefMonth(dateTimePicker1.Value);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = GetFileName();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = GetFileName();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = GetFileName();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox4.Text = GetFileName();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox5.Text = GetFileName();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Form newForm = new ConfigForm();
            newForm.ShowDialog();
            newForm.Dispose();
        }

        private void Button8_Click(object sender, EventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
