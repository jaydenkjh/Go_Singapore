using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Go_Singapore.Controllers;

namespace Go_Singapore.Views
{
	public partial class search1 : System.Web.UI.Page
	{
        APIManager apiManager = new APIManager();
        protected void Page_Load(object sender, EventArgs e)
		{
            Country[] countries = apiManager.GetCountryList();
            foreach (var country in countries)
            {
                ListItem li = new ListItem();
                li.Text = country.currencies[0].code + " " + country.currencies[0].symbol;
                li.Value = country.currencies[0].code;
                // DDLCountry.Items.Add(li);
                DDLCurrency.Items.Add(li);
            }
         
		}
	}
}