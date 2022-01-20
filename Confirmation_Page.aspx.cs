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
                TravellerUniqueID = Agent1.TravellerUniqueIds[Variables.Counter];
                lblTravellerDetails.Text +=
                    "Name : " + Request.Cookies[TravellerUniqueID]["Name"] + "<br>" +
                    "Age : " + Request.Cookies[TravellerUniqueID]["Age"] + "<br>" +
                    "From : " + Request.Cookies[TravellerUniqueID]["From"] + "<br>" +
                    "To : " + Request.Cookies[TravellerUniqueID]["To"] + "<br>";

                if (Variables.isRoundTrip)
                {
                    TravellerUniqueID = Agent1.TravellerUniqueIds[Variables.Counter + 1];
                    lblTravellerDetails.Text +=
                        "Name : " + Request.Cookies[TravellerUniqueID]["Name"] + "<br>" +
                        "Age : " + Request.Cookies[TravellerUniqueID]["Age"] + "<br>" +
                        "From : " + Request.Cookies[TravellerUniqueID]["From"] + "<br>" +
                        "To : " + Request.Cookies[TravellerUniqueID]["To"] + "<br>";
                    Variables.Counter++;
                }
                Variables.Counter++;
            }
            else if (Session["User"].ToString() == "Agent2")
            {
                TravellerUniqueID = Agent2.TravellerUniqueIds[Variables.Counter];
                lblTravellerDetails.Text +=
                    "Name : " + Request.Cookies[TravellerUniqueID]["Name"] + "<br>" +
                    "Age : " + Request.Cookies[TravellerUniqueID]["Age"] + "<br>" +
                    "From : " + Request.Cookies[TravellerUniqueID]["From"] + "<br>" +
                    "To : " + Request.Cookies[TravellerUniqueID]["To"] + "<br>";

                if (Variables.isRoundTrip)
                {
                    TravellerUniqueID = Agent2.TravellerUniqueIds[Variables.Counter + 1];
                    lblTravellerDetails.Text +=
                        "Name : " + Request.Cookies[TravellerUniqueID]["Name"] + "<br>" +
                        "Age : " + Request.Cookies[TravellerUniqueID]["Age"] + "<br>" +
                        "From : " + Request.Cookies[TravellerUniqueID]["From"] + "<br>" +
                        "To : " + Request.Cookies[TravellerUniqueID]["To"] + "<br>";
                    Variables.Counter++;
                }
                Variables.Counter++;
            }
        }
    }
}