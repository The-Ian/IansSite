using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IansSite
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Login.Visible = (Session["User"] == null);

            if (Session["User"] != null)
            {
                User.Visible = true;
                User.Text = "Hello " + Session["User"];
            }

            if (Session["User"] == null)
            {
                Button1.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                Session.Clear();
                Response.Redirect("Login.aspx");
            }
        }
    }
}