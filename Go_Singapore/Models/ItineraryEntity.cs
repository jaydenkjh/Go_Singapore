using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Go_Singapore.Models
{
    public class ItineraryEntity
    {
        public DataTable GetItinearyList()
        {
            DataTable dt = new DataTable ();
            string sql = "SELECT * FROM Itinerary, ItineraryDoList WHERE Itinerary.Id = ItineraryDoList.itineraryId";
            dt = Database.getTable(sql);
            return dt;
        }

        public DataTable GetAttractions()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM Attractions";
            dt = Database.getTable(sql);
            return dt;
        }

       
        public int UpdateItinerary(string sql)
        {
            return Database.ExecuteSQLCommand(sql); //return 0 if failed, return 1 if suggest
        }

    }
}