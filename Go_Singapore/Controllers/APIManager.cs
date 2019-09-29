using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI.WebControls;

namespace Go_Singapore.Controllers
{
    public static class APIManager
    {
        static string countryAPI = String.Format("https://restcountries.eu/rest/v2/all");
        static WebRequest requestObject;
        static HttpWebResponse responseObject;

        public static void GetCountryList()
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
            System.Diagnostics.Debug.WriteLine(strresulttest);

        }
    }
}