using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_Market.Entities;
using System.Data.SqlClient;


namespace DataAccessLayer_Market.Operations
{
   public  class OMCategory
    {
        //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="D:\Fifth Semester\OOP2\Project Work\Project Code\market_management(project)\market_management\MarketDATABASE.mdf";Integrated Security=True;Connect Timeout=30
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Fifth Semester\OOP2\Project Work\Project Code\market_management(project)\market_management\MarketDATABASE.mdf;Integrated Security=True;Connect Timeout=30");
        public int Add(EMCategory add)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Insert into CategoryTbl(Catd, CatName, CatDesc) values('" + add.CatId+ "','" + add.CatName + "','" + add.CatQuantity +"')",Con); 
            int flag= cmd.ExecuteNonQuery();
            Con.Close();
            return flag;
        }
        public SqlDataAdapter Show() 
        {
            Con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from CategoryTbl", Con);
            return sqlDataAdapter;
        }
        public int Edit(EMCategory edit)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Fifth Semester\OOP2\Project Work\Project Code\market_management(project)\market_management\MarketDATABASE.mdf;Integrated Security=True;Connect Timeout=30");
            Con.Open();
            SqlCommand cmd = new SqlCommand ("UPDATE CategoryTbl SET CatName ='" +edit.CatName +"',  CatDesc ='"+ edit.CatQuantity+ "' WHERE Catd ='" +edit.CatId  +"';", Con);  
                 
            int flag = cmd.ExecuteNonQuery();
            Con.Close();
            return flag;
        }
        public int Delete (EMCategory dlt)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Fifth Semester\OOP2\Project Work\Project Code\market_management(project)\market_management\MarketDATABASE.mdf;Integrated Security=True;Connect Timeout=30");
            Con.Open();
            SqlCommand cmd = new SqlCommand("DELETE CategoryTbl  WHERE Catd ='" + dlt.CatId + "';", Con);
            int flag = cmd.ExecuteNonQuery();
            Con.Close();
            return flag;
        }
    }
}
