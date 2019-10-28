using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Go_Singapore.Controllers;
namespace Go_Singapore.Views
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*Example Codes*/

            // For Example, to delete itinerary 
            string id = "0";
            string sql = "DELETE FROM itinerary WHERE id='" + id + "'"; //Remember to enclose your variables with ' '
            ItineraryManager im = new ItineraryManager();
            int result = im.UpdateItinerary(sql);

            /* OR To Update */
            string name = "Potato";
            string sql2 = "UPDATE itinerary SET name='" + name + "' WHERE id='" + id + "'"; //Remember to enclose your variables with ' '
            ItineraryManager im2 = new ItineraryManager();
            int result2 = im.UpdateItinerary(sql);


        }
    }
}