using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Go_Singapore.Controllers;

namespace Go_Singapore.Views
{
    public partial class index1 : System.Web.UI.Page
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        APIManager apiManager = new APIManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            Country[] countryList = apiManager.GetCountryList();
            foreach (var country in countryList)
            {
                ListItem li = new ListItem();
                li.Text = country.name;
                li.Value = country.name;
                // DDLCountry.Items.Add(li);
                DDLCountry.Items.Add(li);
            }

           /* dict = CountryMatcher.GetDictionary();
            foreach (var country in dict)
            {
                ListItem li = new ListItem();
                li.Text = country.Value;
                li.Value = country.Value;
                // DDLCountry.Items.Add(li);
                DDLCountry.Items.Add(li);
            }*/

            updateWeather();
            
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime dateArrival;
            DateTime dateDeparture;
            
            bool error = false;
            string errorLine = "";

            string country = DDLCountry.SelectedItem.Text;
            string dateArr = txtArrival.Text;
            string dateDep = txtDeparture.Text;

            if (!DateTime.TryParse(dateArr, out dateArrival))
            {
                error = true;
                errorLine += "Please enter a valid Arrival Date. DD/MM/YY" + Environment.NewLine;
            }

            if (!DateTime.TryParse(dateDep, out dateDeparture))
            {
                error = true;
                errorLine += "Please enter a valid Departure Date. DD/MM/YY" + Environment.NewLine;
            }

            if (error)
            {
                lblError.Visible = true;
                lblError.Text = errorLine;
            }
            else
            {
                string url = "search.aspx?country=" + country + "&arr=" + dateArr + "&dep=" + dateDep;
                Response.Redirect(url);
            }
        }

        public void updateWeather()
        {
            // Danson please update here
            // To change - lblDay1 - lblDay6, I1 - I6, lblCondition1 to lblCondition6


            DateTime date = DateTime.Now;
            lblDay1.Text = date.ToShortDateString() + ", " + date.DayOfWeek.ToString().Substring(0,3);
            I1.Style.Value = "fas fa-sun";
            I1.Attributes.Add("class", "fas fa-sun"); //Search for the pictures at this site https://fontawesome.com (got rain, sun etc)
            lblCondition1.Text = "Rainy";

        }
    }
}