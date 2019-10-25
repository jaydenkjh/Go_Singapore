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
        string countryAPI = String.Format("https://restcountries.eu/rest/v2/all?fields=name");
        string weatherPI = String.Format("https://api.data.gov.sg/v1/environment/24-hour-weather-forecast");
        WebRequest requestObject;
        HttpWebResponse responseObject;

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