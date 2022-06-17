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
    public partial class Manageproducts : Form
    {
        public Manageproducts()
        {
            InitializeComponent();
        }

        private void btnBc_Click(object sender, EventArgs e)
        {
            /*if(rbMale.Checked)
            {
                MessageBox.Show(rbMale.Text);
            }
            else
            {
                MessageBox.Show(rbFemale.Text);
            }*/

            /*if (chkAI.CheckState == CheckState.Checked)
            {
                MessageBox.Show(chkAI.Text);
            }
            else
            {
                MessageBox.Show(chkSE.Text);
            }*/
            /*GenericClass<int> g = new GenericClass<int>();
            g.Value = 100;
            GenericClass<string> g1 = new GenericClass<string>();
            g1.Value = "Hello";
            listBox1.Items.Add(g.Value);
            listBox1.Items.Add(g1.Value);*/

            List<string> sample = new List<string>();
            sample.Add("OOP2");
            sample.Add("DLC");
            sample.Add("CG");
            listBox1.DataSource = sample;

            /*foreach( var s in sample)
            {

            }*/
        }
    }
}
