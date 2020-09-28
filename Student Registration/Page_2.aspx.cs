using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student_Registration
{
    public partial class Page_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write("Data Saved Successfully....!");
            //Page lastpage = (Page)Context.Handler;
            //lblSName.Text =((TextBox)lastpage.FindControl("txtSName")).Text;



            cookie_func();

            //session_func();



           

        }

        private void session_func()
        {
            this.lblSName.Text = Convert.ToString(Session["Name"]);
            this.lblEmail.Text = Convert.ToString(Session["Email"]);
        }

        private void cookie_func()
        {
            HttpCookie cookie = Request.Cookies["UserInfo"];
            if (cookie != null)
            {
                lblSName.Text = cookie["Name"];
                lblEmail.Text = cookie["Email"];
            }
        }
    }
}