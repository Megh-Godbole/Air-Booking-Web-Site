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
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_TravellerBook_Click(object sender, EventArgs e)
        {
            bool isAgent1 = (Session["User"].ToString() == "Agent1");
            bool isAgent2 = (Session["User"].ToString() == "Agent2");

            if (isAgent1)
            {
                Agent1.TravellerUniqueIds.Add("A1"+GenrateUniqueId.UniqueId.ToString());
                HttpCookie cookie = new HttpCookie(Agent1.TravellerUniqueIds[Variables.A1Counter]);
                cookie["Name"] = tb_TravellerName.Text;
                cookie["Age"] = tb_TravellerAge.Text;
                cookie["From"] = ddl_FromCountrys.SelectedValue;
                cookie["To"] = ddl_ToCountrys.SelectedValue;
                if (ddl_FromCountrys.Text == "IND") { cookie["Date"] = Agent1.FlightDateFromIndToUsa; }
                else if (ddl_FromCountrys.Text == "USA") { cookie["Date"] = Agent1.FlightDateFromUsaToInd; }
                cookie.Expires = DateTime.Now.AddDays(2);
                Response.Cookies.Add(cookie);
                if (cb_IsRoundTrip.Checked)
                {
                    Agent1.TravellerUniqueIds.Add("A1"+GenrateUniqueId.UniqueId.ToString());
                    HttpCookie cookie1 = new HttpCookie(Agent1.TravellerUniqueIds[Variables.A1Counter + 1]);
                    cookie1["Name"] = tb_TravellerName.Text;
                    cookie1["Age"] = tb_TravellerAge.Text;
                    cookie1["From"] = ddl_ToCountrys.SelectedValue;
                    cookie1["To"] = ddl_FromCountrys.SelectedValue;
                    if (ddl_FromCountrys.Text == "IND") { cookie["Date"] = Agent1.FlightDateFromUsaToInd; }
                    else if (ddl_FromCountrys.Text == "USA") { cookie["Date"] = Agent1.FlightDateFromIndToUsa; }
                    cookie1.Expires = DateTime.Now.AddDays(3);
                    Response.Cookies.Add(cookie1);
                }
            }
            else if (isAgent2)
            {
                Agent2.TravellerUniqueIds.Add("A2"+GenrateUniqueId.UniqueId.ToString());
                HttpCookie cookie = new HttpCookie(Agent2.TravellerUniqueIds[Variables.A2Counter]);
                cookie["Name"] = tb_TravellerName.Text;
                cookie["Age"] = tb_TravellerAge.Text;
                cookie["From"] = ddl_FromCountrys.SelectedValue;
                cookie["To"] = ddl_ToCountrys.SelectedValue;
                if (ddl_FromCountrys.Text == "IND") { cookie["Date"] = Agent2.FlightDateFromIndToUsa; }
                else if (ddl_FromCountrys.Text == "USA") { cookie["Date"] = Agent2.FlightDateFromUsaToInd; }
                cookie.Expires = DateTime.Now.AddDays(2);
                Response.Cookies.Add(cookie);

                if (cb_IsRoundTrip.Checked)
                {
                    Agent2.TravellerUniqueIds.Add("A2"+GenrateUniqueId.UniqueId.ToString());
                    HttpCookie cookie1 = new HttpCookie(Agent2.TravellerUniqueIds[Variables.A2Counter + 1]);
                    cookie1["Name"] = tb_TravellerName.Text;
                    cookie1["Age"] = tb_TravellerAge.Text;
                    cookie1["From"] = ddl_ToCountrys.SelectedValue;
                    cookie1["To"] = ddl_FromCountrys.SelectedValue;
                    if (ddl_FromCountrys.Text == "IND") { cookie["Date"] = Agent2.FlightDateFromUsaToInd; }
                    else if (ddl_FromCountrys.Text == "USA") { cookie["Date"] = Agent2.FlightDateFromIndToUsa; }
                    cookie1.Expires = DateTime.Now.AddDays(3);
                    Response.Cookies.Add(cookie1);
                }
            }
            Response.Redirect("~/Confirmation.aspx?isRoundTrip=" + cb_IsRoundTrip.Checked);
        }
    }
}