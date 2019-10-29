using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace Go_Singapore.Models
{
    public class UserEntity
    {
        public DataTable getUsers(string username, string password)
        {
            string sql = "SELECT * FROM USERS WHERE username='" + username + "' AND password='" + password + "'";
            return Database.getTable(sql);
        }

        [Required(ErrorMessage = "Please enter your User ID.")]
        [Display(Name = "Username : ")]
        public string UserId { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter your Password.")]
        [Display(Name = "Password : ")]
        public string Password { get; set; }

        public string UserName { get; set; }

        public String LoginProcess(String strUsername, String strPassword)
        {
            String message = "";
            //my connection string
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GoSingaporeDB.mdf;Integrated Security = True;");
            SqlCommand cmd = new SqlCommand("Select * from Users where username=@Username", con);
            cmd.Parameters.AddWithValue("@Username", strUsername);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Boolean login = (strPassword.Equals(reader["password"].ToString(), StringComparison.InvariantCulture)) ? true : false;
                    if (login)
                    {
                        message = "1";
                        UserName = reader["username"].ToString();

                    }
                    else
                        message = "Invalid Credentials";
                }
                else
                    message = "Invalid Credentials";

                reader.Close();
                reader.Dispose();
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                message = ex.Message.ToString() + "Error.";

            }
            return message;
        }
    }
}
