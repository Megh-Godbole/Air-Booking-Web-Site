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
            lbl_SeatsIndToUsa.Text = Variables.AvailableSeatsIndToUsa.ToString();
            lbl_SeatsUsaToInd.Text = Variables.AvailableSeatsUsaToInd.ToString();

            bool isAgent1 = (Session["User"].ToString() == "Agent1");
            bool isAgent2 = (Session["User"].ToString() == "Agent2");

            if (isAgent1)
            {
                lbl_Name.Text = Agent1.FullName;
                lbl_Country.Text = Agent1.Country;
                lbl_DateIndToUsa.Text = DateTime.Now.AddDays(01).ToShortDateString();
                lbl_DateUsaToInd.Text = DateTime.Now.AddDays(02).ToShortDateString();
            }
            else if (isAgent2)
            {
                lbl_Name.Text = Agent2.FullName;
                lbl_Country.Text = Agent2.Country;
                lbl_DateIndToUsa.Text = DateTime.Now.AddDays(02).ToShortDateString();
                lbl_DateUsaToInd.Text = DateTime.Now.AddDays(01).ToShortDateString();
            }
            else
            {
                lbl_Name.Text = "Something Went Wrong";
                lbl_Country.Text = "Agent Not Found";
            }
        }
    }
}