using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace State_Management_Tasks
{
    public partial class Confirmation_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string TravellerUniqueID = null;
            if (Session["User"].ToString() == "Agent1")
            {
                TravellerUniqueID = Agent1.TravellerUniqueIds[Variables.A1Counter];
                lblTravellerDetails.Text +=
                    "Name : " + Request.Cookies[TravellerUniqueID]["Name"] + "<br>" +
                    "Age : " + Request.Cookies[TravellerUniqueID]["Age"] + "<br>" +
                    "From : " + Request.Cookies[TravellerUniqueID]["From"] + "<br>" +
                    "To : " + Request.Cookies[TravellerUniqueID]["To"] + "<br>";

                if (Variables.isRoundTrip)
                {
                    lblTravellerDetails.Text += "For Round Trip<br>" +
                        "From : " + Request.Cookies[TravellerUniqueID]["RT_From"] + "<br>" +
                        "To : " + Request.Cookies[TravellerUniqueID]["RT_To"] + "<br>";
                }
                Variables.A1Counter++;
            }
            else if (Session["User"].ToString() == "Agent2")
            {
                TravellerUniqueID = Agent2.TravellerUniqueIds[Variables.A2Counter];
                lblTravellerDetails.Text +=
                    "Name : " + Request.Cookies[TravellerUniqueID]["Name"] + "<br>" +
                    "Age : " + Request.Cookies[TravellerUniqueID]["Age"] + "<br>" +
                    "From : " + Request.Cookies[TravellerUniqueID]["From"] + "<br>" +
                    "To : " + Request.Cookies[TravellerUniqueID]["To"] + "<br>";

                if (Variables.isRoundTrip)
                {
                    lblTravellerDetails.Text += "For Round Trip<br>" +
                        "From : " + Request.Cookies[TravellerUniqueID]["RT_From"] + "<br>" +
                        "To : " + Request.Cookies[TravellerUniqueID]["RT_To"] + "<br>";
                }
                Variables.A2Counter++;
            }
        }
    }
}