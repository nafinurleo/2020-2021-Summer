using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Id = txtid.Text;
            ListInfo.Items.Add(c.Id);
            c.Password = txtpassword.Text;
            ListInfo.Items.Add(c.Password);
        }
    }
}
