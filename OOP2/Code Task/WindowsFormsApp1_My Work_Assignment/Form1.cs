using DataAccessLibrary.Entities;
using DataAccessLibrary.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_My_Work_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EStudent eStudent = new EStudent();
            OStudent oStudent = new OStudent();

            eStudent.Id = txtId.Text;
            eStudent.Name = txtName.Text;

            int flag = oStudent.Insert(eStudent);
            if(flag>0)
            {
                MessageBox.Show("Successfully inserted");
            }
            else
            {
                MessageBox.Show("Not inserted");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EStudent eStudent = new EStudent();
            OStudent oStudent = new OStudent();

            eStudent.Id = txtId.Text;
            eStudent.Name = txtName.Text;

            int flag = oStudent.Delete(eStudent);
            if (flag > 0)
            {
                MessageBox.Show("Successfully deleted");
            }
            else
            {
                MessageBox.Show("Not deleted");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EStudent eStudent = new EStudent();
            OStudent oStudent = new OStudent();

            eStudent.Id = txtId.Text;
            eStudent.Name = txtName.Text;

            int flag = oStudent.Update(eStudent);
            if (flag > 0)
            {
                MessageBox.Show("Successfully updated");
            }
            else
            {
                MessageBox.Show("Not updated");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            OStudent oStudent = new OStudent();
            SqlDataAdapter sqlDataAdapter = oStudent.Show();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}
