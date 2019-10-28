using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Go_Singapore.Models
{
    public class SuggestionEntity
    {
        public DataTable GetFullAttractionList()
        {
            DataTable dt;
            string sql = "SELECT * FROM Attractions";
            dt = Database.getTable(sql);
            return dt;
        } 
    }
}