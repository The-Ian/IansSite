using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace IansSite
{
    public partial class Login : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["Login"] = "False";
            }

            else
            {
                
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          
            string myStringVariable = string.Empty;

            string result = "";

            if (ViewState["Login"].ToString() != "True")
            {
                using (SQL_Data data = new SQL_Data())
                {
                    result = data.Verification(userTB.Text, passTB.Text);
                }

                    myStringVariable = result;

                if (result == "Proceed")
                {
                    ViewState["Login"] = "True";
                    Session["User"] = userTB.Text;
                    Response.Redirect("Default.aspx");
                }
            }
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + myStringVariable + "');", true);


        }
    }
}