using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Go_Singapore.Models
{
    public static class Database
    {
        
        static SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GoSingaporeDB.mdf;Integrated Security = True;");

        //Read data from database
        public static DataTable getTable(string sql)
        {
            DataTable results = null;
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                results = new DataTable();
                results.Load(reader);
            }
            reader.Close();
            con.Close();

            return results;
        }

        //
             
    }
}