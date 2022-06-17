using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_My_Work_Week8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(txtNumber1.Text);
            int number2 = Convert.ToInt32(txtNumber2.Text);
            int result = number1 + number2;;
            lb1Result.Text = "The result is " +result;
            lb1Result.Visible = true;
            // MessageBox.Show("The result is " +result);
        }

        private void btnClick1_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(txtNumber1.Text);
            int number2 = Convert.ToInt32(txtNumber2.Text);
            int result = number1 - number2;
            lb1Result.Text = "The result is " + result;
            lb1Result.Visible = true;
        }

        private void btClick2_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(txtNumber1.Text);
            int number2 = Convert.ToInt32(txtNumber2.Text);
            int result = number1 * number2;
            lb1Result.Text = "The result is " + result;
            lb1Result.Visible = true;
        }

        private void btClick3_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(txtNumber1.Text);
            int number2 = Convert.ToInt32(txtNumber2.Text);
            if (number2 != 0)
            {
                int result = number1 / number2;
                lb1Result.Text = "The result is " + result;
                lb1Result.Visible = true; 
            }
            if (number2 == 0)
            {
                MessageBox.Show("Divided by zero is not possible.");
            }
        }
    }
}
