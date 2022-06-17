using DataAccessLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Operations
{
    public class OStudent
    {
        SqlConnection connection = new SqlConnection("Data Source=Leo;Initial Catalog=DbConnection1;Integrated Security=True");
        public int Insert(EStudent eStudent)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Insert into StudentTable(Id, Name) values('" + eStudent.Id + "','" + eStudent.Name + "')", connection);
            int flag = cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }

        public int Delete(EStudent eStudent)
        {
            connection.Open();
            SqlCommand cm = new SqlCommand("Delete from StudentTable where name=('" + eStudent.Name + "')", connection);
            int flag = cm.ExecuteNonQuery();
            connection.Close();
            return flag;
        }

        public int Update(EStudent eStudent)
        {
            connection.Open();
            SqlCommand cm = new SqlCommand("Update StudentTable set name=' " + eStudent.Name + " ' where id='" + eStudent.Id + "'", connection);
            int flag = cm.ExecuteNonQuery();
            connection.Close();
            return flag;
        }

        public SqlDataAdapter Show()
        {
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from StudentTable", connection);
            connection.Close();
            return sqlDataAdapter;
        }
    }
}
