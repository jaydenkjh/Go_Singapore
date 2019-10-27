using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using Go_Singapore.Models;

namespace Go_Singapore.Controllers
{
    public class APIManager
    {
        private string countryAPI = String.Format("https://restcountries.eu/rest/v2/all?fields=name;currencies");
        private string weatherPI = String.Format("https://api.data.gov.sg/v1/environment/24-hour-weather-forecast");
        private string currency = String.Format("http://data.fixer.io/api/latest?access_key=58c1104541e6b2a3b5438cba29cd46ce&format=1");
        private string attractionAPI = String.Format("https://www.visitsingapore.com/ysapi-services/RequestAPI?format=details&locale=en&pageid=84");
        WebRequest requestObject;
        HttpWebResponse responseObject;

        void getAttractions()
        {
            requestObject = WebRequest.Create(attractionAPI);
            requestObject.Method = "GET";
            responseObject = null;
            responseObject = (HttpWebResponse)requestObject.GetResponse();

            string strresulttest = null;
            using (Stream stream = responseObject.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                strresulttest = sr.ReadToEnd();
                sr.Close();
            }

            Item[] weatherForecast = new JavaScriptSerializer().Deserialize<Item[]>(strresulttest);
            return weatherForecast[0];

        }

       /* public Country GetCurrency()
        {
            requestObject = WebRequest.Create(countryAPI);
            requestObject.Method = "GET";
            responseObject = null;
            responseObject = (HttpWebResponse)requestObject.GetResponse();

            string strresulttest = null;
            using (Stream stream = responseObject.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                strresulttest = sr.ReadToEnd();
                sr.Close();
            }

            Rates weatherForecast = new JavaScriptSerializer().Deserialize<Rates>(strresulttest);
            return weatherForecast;
        }*/

       


        public Item getWeatherForeCast()
        {
            requestObject = WebRequest.Create(weatherPI);
            requestObject.Method = "GET";
            responseObject = null;
            responseObject = (HttpWebResponse)requestObject.GetResponse();

            string strresulttest = null;
            using (Stream stream = responseObject.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                strresulttest = sr.ReadToEnd();
                sr.Close();
            }

            Item[] weatherForecast = new JavaScriptSerializer().Deserialize<Item[]>(strresulttest);
            return weatherForecast[0];
        }
    

        public Country[] GetCountryList()
        {
            requestObject = WebRequest.Create(countryAPI);
            requestObject.Method = "GET";
            responseObject = null;
            responseObject = (HttpWebResponse)requestObject.GetResponse();

            string strresulttest = null;
            using (Stream stream = responseObject.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                strresulttest = sr.ReadToEnd();
                sr.Close();
            }

            Country[] countryList = new JavaScriptSerializer().Deserialize<Country[]>(strresulttest);
            return countryList;
            }
    }
}