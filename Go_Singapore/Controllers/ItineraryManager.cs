using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Go_Singapore.Models;

namespace Go_Singapore.Controllers
{
    public class ItineraryManager
    {
        public DataTable GetItinearyList()
        {
            ItineraryEntity ie = new ItineraryEntity();
            return ie.GetItinearyList();
        }

        public int UpdateItinerary(string sql)
        {
            ItineraryEntity ie = new ItineraryEntity();
            return ie.UpdateItinerary(sql);
        }
    }
}