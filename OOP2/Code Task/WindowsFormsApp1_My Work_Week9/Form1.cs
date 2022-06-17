using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_My_Work_Week9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbValue.Text = cboCountry.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dob = dateTimePicker1.Value;
            DateTime current = DateTime.Now;
            TimeSpan timeSpan = current - dob;
            textBox1.Text = (timeSpan.TotalDays / 365).ToString("0");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int rowNumber = dataGridView1.Rows.Add();
            dataGridView1.Rows[rowNumber].Cells[0].Value = cboCountry.Text;
            dataGridView1.Rows[rowNumber].Cells[1].Value = textBox1.Text;
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Do not enter value. This field will be calculated automatically";
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
    }
}
