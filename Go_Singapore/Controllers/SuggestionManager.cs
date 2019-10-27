using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Go_Singapore.Models;

namespace Go_Singapore.Controllers
{
    public class SuggestionManager
    {
        public DataTable GetFullSuggestionList()
        {
            SuggestionEntity se = new SuggestionEntity();
            return se.GetFullAttractionList();
        }
    }
}