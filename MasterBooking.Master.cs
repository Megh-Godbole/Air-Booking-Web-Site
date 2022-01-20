using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace State_Management_Tasks
{
    public partial class MasterBooking : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
            bool isAgent1 = (Session["User"].ToString() == "Agent1");
            bool isAgent2 = (Session["User"].ToString() == "Agent2");

            if (isAgent1)
            {
                lbl_Name.Text = Agent1.FullName;
                lbl_Country.Text = Agent1.Country;
                lblCountrys1.Text = "IND To USA";
                lblCountrys2.Text = "USA To IND";
                lbl_Date1.Text = Agent1.FlightDateFromIndToUsa = DateTime.Now.AddDays(01).ToShortDateString();
                lbl_Date2.Text = Agent1.FlightDateFromUsaToInd = DateTime.Now.AddDays(02).ToShortDateString();
                lbl_Seats1.Text = Variables.AvailableSeatsIndToUsa1.ToString();
                lbl_Seats2.Text = Variables.AvailableSeatsUsaToInd1.ToString();
            }
            else if (isAgent2)
            {
                lbl_Name.Text = Agent2.FullName;
                lbl_Country.Text = Agent2.Country;
                lblCountrys1.Text = "USA To IND";
                lblCountrys2.Text = "IND To USA";
                lbl_Date1.Text = Agent2.FlightDateFromIndToUsa = DateTime.Now.AddDays(02).ToShortDateString();
                lbl_Date2.Text = Agent2.FlightDateFromUsaToInd = DateTime.Now.AddDays(03).ToShortDateString();
                lbl_Seats1.Text = Variables.AvailableSeatsUsaToInd1.ToString();
                lbl_Seats2.Text = Variables.AvailableSeatsIndToUsa2.ToString();

            }
            else
            {
                lbl_Name.Text = "Something Went Wrong";
                lbl_Country.Text = "Agent Not Found";
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("~/Login_Page.aspx");
        }
    }
}