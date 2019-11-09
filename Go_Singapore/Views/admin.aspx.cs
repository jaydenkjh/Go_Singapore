using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Go_Singapore.Controllers;
using Go_Singapore.Models;

namespace Go_Singapore.Views
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*Example Codes*/

            // For Example, to delete itinerary 
            string sql = "SELECT * FROM Attractions";
            DataTable dt = Database.getTable(sql);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}