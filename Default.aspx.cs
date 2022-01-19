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
                if (cb_IsRoundTrip.Checked)
                {
                    GenrateUniqueId Genrate = new GenrateUniqueId();
                    Agent1.TravellerUniqueIds.Add(Genrate.UniqueId);
                    Session["UniqueId"] = Agent1.TravellerUniqueIds[Variables.Counter];
                    HttpCookie cookie = new HttpCookie(Session["UniqueId"].ToString());
                    cookie["Name"] = tb_TravellerName.Text;
                    cookie["Age"] = tb_TravellerAge.Text;
                    cookie["From"] = ddl_FromCountrys.SelectedValue;
                    cookie["To"] = ddl_ToCountrys.SelectedValue;
                    cookie.Expires = DateTime.Now.AddDays(2);
                    Response.Cookies.Add(cookie);

                    GenrateUniqueId Genrate1 = new GenrateUniqueId();
                    Agent1.TravellerUniqueIds.Add(Genrate1.UniqueId);
                    Session["RoundTripUniqueId"] = Agent1.TravellerUniqueIds[Variables.Counter + 1];
                    HttpCookie cookie1 = new HttpCookie(Session["RoundTripUniqueId"].ToString());
                    cookie["Name"] = tb_TravellerName.Text;
                    cookie["Age"] = tb_TravellerAge.Text;
                    cookie["From"] = ddl_ToCountrys.SelectedValue;
                    cookie["To"] = ddl_FromCountrys.SelectedValue;
                    cookie.Expires = DateTime.Now.AddDays(3);
                    Response.Cookies.Add(cookie1);
                }
                else
                {
                    GenrateUniqueId Genrate = new GenrateUniqueId();
                    Agent1.TravellerUniqueIds.Add(Genrate.UniqueId);
                    Session["UniqueId"] = Agent1.TravellerUniqueIds[Variables.Counter];
                    HttpCookie cookie = new HttpCookie(Session["UniqueId"].ToString());
                    cookie["Name"] = tb_TravellerName.Text;
                    cookie["Age"] = tb_TravellerAge.Text;
                    cookie["From"] = ddl_FromCountrys.SelectedValue;
                    cookie["To"] = ddl_ToCountrys.SelectedValue;
                    cookie.Expires = DateTime.Now.AddDays(2);
                    Response.Cookies.Add(cookie);
                }
            }
            else if (isAgent2)
            {
                if (cb_IsRoundTrip.Checked)
                {
                    GenrateUniqueId Genrate = new GenrateUniqueId();
                    Agent2.TravellerUniqueIds.Add(Genrate.UniqueId);
                    Session["UniqueId"] = Agent2.TravellerUniqueIds[Variables.Counter];
                    HttpCookie cookie = new HttpCookie(Session["UniqueId"].ToString());
                    cookie["Name"] = tb_TravellerName.Text;
                    cookie["Age"] = tb_TravellerAge.Text;
                    cookie["From"] = ddl_FromCountrys.SelectedValue;
                    cookie["To"] = ddl_ToCountrys.SelectedValue;
                    cookie.Expires = DateTime.Now.AddDays(2);
                    Response.Cookies.Add(cookie);

                    GenrateUniqueId Genrate1 = new GenrateUniqueId();
                    Agent2.TravellerUniqueIds.Add(Genrate1.UniqueId);
                    Session["RoundTripUniqueId"] = Agent2.TravellerUniqueIds[Variables.Counter + 1];
                    HttpCookie cookie1 = new HttpCookie(Session["RoundTripUniqueId"].ToString());
                    cookie["Name"] = tb_TravellerName.Text;
                    cookie["Age"] = tb_TravellerAge.Text;
                    cookie["From"] = ddl_ToCountrys.SelectedValue;
                    cookie["To"] = ddl_FromCountrys.SelectedValue;
                    cookie.Expires = DateTime.Now.AddDays(3);
                    Response.Cookies.Add(cookie1);
                //changes
                }
                else
                {
                    GenrateUniqueId Genrate = new GenrateUniqueId();
                    Agent2.TravellerUniqueIds.Add(Genrate.UniqueId);
                    Session["UniqueId"] = Agent2.TravellerUniqueIds[Variables.Counter];
                    HttpCookie cookie = new HttpCookie(Session["UniqueId"].ToString());
                    cookie["Name"] = tb_TravellerName.Text;
                    cookie["Age"] = tb_TravellerAge.Text;
                    cookie["From"] = ddl_FromCountrys.SelectedValue;
                    cookie["To"] = ddl_ToCountrys.SelectedValue;
                    cookie.Expires = DateTime.Now.AddDays(2);
                    Response.Cookies.Add(cookie);
                }
            }
            Response.Redirect("~/Confirmation.aspx?isRoundTrip=" + cb_IsRoundTrip.Checked);
        }
    }
}