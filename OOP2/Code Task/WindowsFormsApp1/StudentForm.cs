using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Name = txtname.Text;
            ListInfo.Items.Add(s.Name);
            s.Id = txtid.Text;
            ListInfo.Items.Add(s.Id);
            s.Cgpa = txtcgpa.Text;
            ListInfo.Items.Add(s.Cgpa);
            s.Age = txtage.Text;
            ListInfo.Items.Add(s.Age);
            s.Program = txtprogram.Text;
            ListInfo.Items.Add(s.Program);
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            if (rbtnMale.Checked)
            {
                MessageBox.Show(rbtnMale.Text);
            }
            else
            {
                MessageBox.Show(rbtnFemale.Text);
            }
        }

        private void btnTick_Click(object sender, EventArgs e)
        {
            if (chkAI.CheckState == CheckState.Checked)
            {
                MessageBox.Show(chkAI.Text);
            }
            else
            {
                MessageBox.Show(chkSE.Text);
            }
        }
    }
}
