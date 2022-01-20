using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace State_Management_Tasks
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Variables.isRoundTrip = (Request.QueryString["isRoundTrip"] == "True");
            bool isFromInd = false;
            bool isFromUSA = false;
            if (Session["User"].ToString() == "Agent1")
            {
                isFromInd = (Request.Cookies[Agent1.TravellerUniqueIds[Variables.A1Counter]]["From"] == "IND");
                isFromUSA = (Request.Cookies[Agent1.TravellerUniqueIds[Variables.A1Counter]]["From"] == "USA");

                if (isFromInd) { Variables.AvailableSeatsIndToUsa1--; }
                else if (isFromUSA) { Variables.AvailableSeatsUsaToInd1--; }
                if (Variables.isRoundTrip)
                {
                    if (!isFromInd) { Variables.AvailableSeatsIndToUsa1--; }
                    else if (!isFromUSA) { Variables.AvailableSeatsUsaToInd1--; }
                }
            }
            else if (Session["User"].ToString() == "Agent2")
            {
                isFromInd = (Request.Cookies[Agent2.TravellerUniqueIds[Variables.A2Counter]]["From"] == "IND");
                isFromUSA = (Request.Cookies[Agent2.TravellerUniqueIds[Variables.A2Counter]]["From"] == "USA");

                if (isFromInd) { Variables.AvailableSeatsIndToUsa2--; }
                else if (isFromUSA) { Variables.AvailableSeatsUsaToInd1--; }
                if (Variables.isRoundTrip)
                {
                    if (!isFromInd) { Variables.AvailableSeatsIndToUsa2--; }
                    else if (!isFromUSA) { Variables.AvailableSeatsUsaToInd1--; }
                }
            }
        }
    }
}