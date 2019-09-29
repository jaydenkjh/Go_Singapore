using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Go_Singapore.Controllers;

public partial class View_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        APIManager.GetCountryList();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {

    }

}