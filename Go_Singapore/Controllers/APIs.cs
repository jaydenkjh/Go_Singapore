using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Go_Singapore.Controllers
{


    public class CurrencyRate
    {
        public Rates rates { get; set; }
        public string _base { get; set; }
        public string date { get; set; }
    }

    public class Rates
    {
        public float CAD { get; set; }
        public float HKD { get; set; }
        public float ISK { get; set; }
        public float PHP { get; set; }
        public float DKK { get; set; }
        public float HUF { get; set; }
        public float CZK { get; set; }
        public float AUD { get; set; }
        public float RON { get; set; }
        public float SEK { get; set; }
        public float IDR { get; set; }
        public float INR { get; set; }
        public float BRL { get; set; }
        public float RUB { get; set; }
        public float HRK { get; set; }
        public float JPY { get; set; }
        public float THB { get; set; }
        public float CHF { get; set; }
        public float SGD { get; set; }
        public float PLN { get; set; }
        public float BGN { get; set; }
        public float TRY { get; set; }
        public float CNY { get; set; }
        public float NOK { get; set; }
        public float NZD { get; set; }
        public float ZAR { get; set; }
        public float USD { get; set; }
        public float MXN { get; set; }
        public float ILS { get; set; }
        public float GBP { get; set; }
        public float KRW { get; set; }
        public float MYR { get; set; }
    }

    public class Currency
    {
        public string code { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class Country
    {
        public List<Currency> currencies { get; set; }
        public string name { get; set; }
    }

    public class Rootobject
    {
        public Item[] items { get; set; }
        public Api_Info api_info { get; set; }
    }

    public class Api_Info
    {
        public string status { get; set; }
    }

    public class Item
    {
        public DateTime update_timestamp { get; set; }
        public DateTime timestamp { get; set; }
        public Valid_Period valid_period { get; set; }
        public General general { get; set; }
        public Period[] periods { get; set; }
    }

    public class Valid_Period
    {
        public DateTime start { get; set; }
        public DateTime end { get; set; }
    }

    public class General
    {
        public string forecast { get; set; }
        public Relative_Humidity relative_humidity { get; set; }
        public Temperature temperature { get; set; }
        public Wind wind { get; set; }
    }

    public class Relative_Humidity
    {
        public int low { get; set; }
        public int high { get; set; }
    }

    public class Temperature
    {
        public int low { get; set; }
        public int high { get; set; }
    }

    public class Wind
    {
        public Speed speed { get; set; }
        public string direction { get; set; }
    }

    public class Speed
    {
        public int low { get; set; }
        public int high { get; set; }
    }

    public class Period
    {
        public Time time { get; set; }
        public Regions regions { get; set; }
    }

    public class Time
    {
        public DateTime start { get; set; }
        public DateTime end { get; set; }
    }

    public class Regions
    {
        public string west { get; set; }
        public string east { get; set; }
        public string central { get; set; }
        public string south { get; set; }
        public string north { get; set; }
    }



}