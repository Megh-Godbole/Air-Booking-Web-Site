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
            if (Session["User"].ToString() == "Agent1")
            {
                lblName.Text = Request.Cookies[Agent1.TravellerUniqueIds[Variables.Counter]]["Name"];
                lblAge.Text = Request.Cookies[Agent1.TravellerUniqueIds[Variables.Counter]]["Age"];
                lblFrom.Text = Request.Cookies[Agent1.TravellerUniqueIds[Variables.Counter]]["From"];
                lblTo.Text = Request.Cookies[Agent1.TravellerUniqueIds[Variables.Counter]]["To"];
                if (Variables.isRoundTrip)
                {
                    lblName.Text = Request.Cookies[Agent1.TravellerUniqueIds[Variables.Counter + 1]]["Name"];
                    lblAge.Text = Request.Cookies[Agent1.TravellerUniqueIds[Variables.Counter + 1]]["Age"];
                    lblFrom.Text = Request.Cookies[Agent1.TravellerUniqueIds[Variables.Counter + 1]]["From"];
                    lblTo.Text = Request.Cookies[Agent1.TravellerUniqueIds[Variables.Counter + 1]]["To"];
                    Variables.Counter++;
                }
                Variables.Counter++;
            }
            else if (Session["User"].ToString() == "Agent2")
            {
                lblName.Text = Request.Cookies[Agent2.TravellerUniqueIds[Variables.Counter]]["Name"];
                lblAge.Text = Request.Cookies[Agent2.TravellerUniqueIds[Variables.Counter]]["Age"];
                lblFrom.Text = Request.Cookies[Agent2.TravellerUniqueIds[Variables.Counter]]["From"];
                lblTo.Text = Request.Cookies[Agent2.TravellerUniqueIds[Variables.Counter]]["To"];
                if (Variables.isRoundTrip)
                {
                    lblName.Text = Request.Cookies[Agent2.TravellerUniqueIds[Variables.Counter + 1]]["Name"];
                    lblAge.Text = Request.Cookies[Agent2.TravellerUniqueIds[Variables.Counter + 1]]["Age"];
                    lblFrom.Text = Request.Cookies[Agent2.TravellerUniqueIds[Variables.Counter + 1]]["From"];
                    lblTo.Text = Request.Cookies[Agent2.TravellerUniqueIds[Variables.Counter + 1]]["To"];
                    Variables.Counter++;
                }
                Variables.Counter++;
            }
        }
    }
}