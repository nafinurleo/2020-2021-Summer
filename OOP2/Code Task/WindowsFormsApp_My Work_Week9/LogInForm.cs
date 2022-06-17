using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_My_Work_Week9
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void linksignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SignupForm().Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtusername.Text.Trim();
            string Password = txtpassword.Text.Trim();
            if (Username.Equals("Leo") && Password.Equals("1234"))
            {
                new Manageproducts().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check username or password for login");
            }
        }
    }
}
