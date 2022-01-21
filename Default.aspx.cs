using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace State_Management_Tasks
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public bool isAgent1 = false;
        public bool isAgent2 = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            isAgent1 = (Session["User"].ToString() == "Agent1");
            isAgent2 = (Session["User"].ToString() == "Agent2");
            if (isAgent1)
            {
                ddl_FromCountrys.Items.Remove("USA");
                ddl_ToCountrys.Items.Remove("IND");
            }
            else if (isAgent2)
            {
                ddl_FromCountrys.Items.Remove("IND");
                ddl_ToCountrys.Items.Remove("USA");
            }
        }
        protected void btn_TravellerBook_Click(object sender, EventArgs e)
        {
            if (isAgent1)
            {
                Variables.UniqueId++;
                Agent1.TravellerUniqueIds.Add("A1"+Variables.UniqueId.ToString());
                HttpCookie cookie = new HttpCookie(Agent1.TravellerUniqueIds[Variables.A1Counter]);
                cookie["Name"] = tb_TravellerName.Text;
                cookie["Age"] = tb_TravellerAge.Text;
                cookie["From"] = ddl_FromCountrys.SelectedValue;
                cookie["To"] = ddl_ToCountrys.SelectedValue;
                if (ddl_FromCountrys.Text == "IND") { cookie["Date"] = Agent1.FlightDateFromIndToUsa; }
                else if (ddl_FromCountrys.Text == "USA") { cookie["Date"] = Agent1.FlightDateFromUsaToInd; }
                cookie.Expires = DateTime.Now.AddDays(2);
                if (cb_IsRoundTrip.Checked)
                {
                    cookie["isRoundTrip"] = cb_IsRoundTrip.Checked.ToString();
                    cookie["RT_From"] = ddl_ToCountrys.SelectedValue;
                    cookie["RT_To"] = ddl_FromCountrys.SelectedValue;
                    if (ddl_FromCountrys.Text == "IND") { cookie["RT_Date"] = Agent1.FlightDateFromUsaToInd; }
                    else if (ddl_FromCountrys.Text == "USA") { cookie["RT_Date"] = Agent1.FlightDateFromIndToUsa; }
                    cookie.Expires = DateTime.Now.AddDays(3);
                }
                Response.Cookies.Add(cookie);
            }
            else if (isAgent2)
            {
                Variables.UniqueId++;
                Agent2.TravellerUniqueIds.Add("A2"+Variables.UniqueId.ToString());
                HttpCookie cookie = new HttpCookie(Agent2.TravellerUniqueIds[Variables.A2Counter]);
                cookie["Name"] = tb_TravellerName.Text;
                cookie["Age"] = tb_TravellerAge.Text;
                cookie["From"] = ddl_FromCountrys.SelectedValue;
                cookie["To"] = ddl_ToCountrys.SelectedValue;
                if (ddl_FromCountrys.Text == "IND") { cookie["Date"] = Agent2.FlightDateFromIndToUsa; }
                else if (ddl_FromCountrys.Text == "USA") { cookie["Date"] = Agent2.FlightDateFromUsaToInd; }
                cookie.Expires = DateTime.Now.AddDays(2);
                if (cb_IsRoundTrip.Checked)
                {
                    cookie["isRoundTrip"] = cb_IsRoundTrip.Checked.ToString();
                    cookie["RT_From"] = ddl_ToCountrys.SelectedValue;
                    cookie["RT_To"] = ddl_FromCountrys.SelectedValue;
                    if (ddl_FromCountrys.Text == "IND") { cookie["RT_Date"] = Agent2.FlightDateFromUsaToInd; }
                    else if (ddl_FromCountrys.Text == "USA") { cookie["RT_Date"] = Agent2.FlightDateFromIndToUsa; }
                    cookie.Expires = DateTime.Now.AddDays(3);
                }
                Response.Cookies.Add(cookie);
            }
            Response.Redirect("~/Confirmation.aspx?isRoundTrip=" + cb_IsRoundTrip.Checked);
        }
    }
}