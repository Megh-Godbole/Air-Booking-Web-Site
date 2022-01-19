using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace State_Management_Tasks
{
    public partial class Login_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            string username = tb_UserName.Text;
            string password = tb_Password.Text;
            bool isValidAgent1 = (username == Agent1.UserName && password == Agent1.Password);
            bool isValidAgent2 = (username == Agent2.UserName && password == Agent2.Password);
            
            if (isValidAgent1)
            {
                Response.Redirect("~/Default.aspx", false);
                Session["User"] = "Agent1";
            }
            else if (isValidAgent2)
            {
                Response.Redirect("~/Default.aspx", false);
                Session["User"] = "Agent2";
            }
            else
            {
                lbl_Messege.Text = "Invalid User Name & Password <br> Please Try Again!!!!";
            }
        }
    }
}