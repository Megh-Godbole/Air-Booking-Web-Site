using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace State_Management_Tasks
{
    public partial class BookingDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Details = null;
            int counter = 1;
            if (Session["User"].ToString() == "Agent1")
            {
                foreach(var TravellerId in Agent1.TravellerUniqueIds)
                {
                    Details += "Traveller" + counter + "<br>" +
                                "Name : " + Request.Cookies[TravellerId]["Name"] + "<br>" +
                                "Age : " + Request.Cookies[TravellerId]["Age"] + "<br>" +
                                "From : " + Request.Cookies[TravellerId]["From"] + "<br>" +
                                "To : " + Request.Cookies[TravellerId]["To"] + "<br>" +
                                "Travelling Date : " + "Work In Progress" + "<br><br>";
                    counter++;
                }
            }
            else if (Session["User"].ToString() == "Agent2")
            {
                foreach (var TravellerId in Agent2.TravellerUniqueIds)
                {
                    Details += "Traveller" + counter + "<br>" +
                                "Name : " + Request.Cookies[TravellerId]["Name"] + "<br>" +
                                "Age : " + Request.Cookies[TravellerId]["Age"] + "<br>" +
                                "From : " + Request.Cookies[TravellerId]["From"] + "<br>" +
                                "To : " + Request.Cookies[TravellerId]["To"] + "<br>" +
                                "Travelling Date : " + "Work In Progress" + "<br><br>";
                    counter++;
                }
            }
        }
    }
}