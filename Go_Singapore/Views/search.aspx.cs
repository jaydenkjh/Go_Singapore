using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        float sgdRate = 0;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Country[] countries = apiManager.GetCountryList();
           /* foreach (var country in countries)
            {

                foreach (var currency in country.currencies)
                {
                    ListItem li = new ListItem();
                    li.Text = country.currencies[0].name + " " + country.currencies[0].symbol;
                    li.Value = country.currencies[0].code;
                    DDLCurrency.Items.Add(li);
                }
                // DDLCountry.Items.Add(li);


            }*/

            Rates rates = apiManager.GetCurrency();
     
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(rates))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(rates);
                if (name=="SGD")
                {
                    sgdRate = float.Parse(value.ToString());
                }
                ListItem li = new ListItem();
                li.Text = name;
                li.Value = name;
                DDLCurrency.Items.Add(li);
                //Console.WriteLine("{0}={1}", name, value);
            }

            var item = CountryMatcher.GetDictionary();
       

      
            if (!IsPostBack)
            {
                DDLCurrency.SelectedValue = "SGD";
                updateCost(DDLCurrency.SelectedItem.Text,DDLStyle.Text, sgdRate);
            }
        }

        public void updateCost(string currencyName, string style, float rates)
        {
            Datum[] costList = apiManager.GetCost();
            foreach (var cost in costList)
            {
                if (cost.category_id == "0")
                {
                    lblCost6.Text = currencyName + " " + Math.Round(float.Parse(returnPrice(style, cost))/ sgdRate * rates, 2).ToString();
                }
                else if (cost.category_id == "1")
                {
                    lblCost1.Text = currencyName + " " + Math.Round(float.Parse(returnPrice(style, cost)) / sgdRate * rates, 2).ToString();
                }
                else if (cost.category_id == "3")
                {
                    lblCost2.Text = currencyName + " " + Math.Round(float.Parse(returnPrice(style, cost)) / sgdRate * rates, 2).ToString();
                }
                else if (cost.category_id == "4")
                {
                    lblCost3.Text = currencyName + " " + Math.Round(float.Parse(returnPrice(style, cost)) / sgdRate * rates, 2).ToString();
                }
                else if (cost.category_id == "6")
                {
                    lblCost4.Text = currencyName + " " + Math.Round(float.Parse(returnPrice(style, cost)) / sgdRate * rates, 2).ToString();
                }
                else if (cost.category_id == "5")
                {
                    lblCost5.Text = currencyName + " " + Math.Round(float.Parse(returnPrice(style, cost)) / sgdRate * rates, 2).ToString();
                }

            }
        }

        public string returnPrice(string style, Datum cost)
        {
            if (style == "Budget")
            {
                return cost.value_budget;
            }
            else if (style == "Mid-Range")
            {
                return cost.value_midrange;
            }
            else
            {
                return cost.value_luxury;
            }
        }

        protected void DDLCurrency_TextChanged(object sender, EventArgs e)
        {
            Rates rates = apiManager.GetCurrency();
            string style = DDLStyle.SelectedItem.Text;
            float rate = float.Parse(rates.GetType().GetProperty(DDLCurrency.SelectedItem.Text).GetValue(rates, null).ToString());
            updateCost(DDLCurrency.SelectedItem.Text,style, rate);
        }
    }
}