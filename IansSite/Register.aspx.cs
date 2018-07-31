using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace IansSite
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["Register"] = "False";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SQL_Data data = new SQL_Data();
            string result;


            if (ViewState["Register"].ToString() != "True")
            {
                    result = data.VerifyUser(userTB.Text);     
            }

            else if (passTB.Text == "" || conpassTB.Text == "")
            {
                Response.Write("Input your password first.");
            }

            //else if (userTB.Text != select.Parameters)
            //{
            //    Response.Write("User already exists.");
            //}
            

            else if (userTB.Text == "")
            {
                Response.Write("Input a username.");
            }

            else if (passTB.Text != conpassTB.Text)
            {
                Response.Write("Your passwords do not match.");
            }

            else if (passTB.Text == conpassTB.Text)
            {
      
                SqlCommand insert = new SqlCommand("insert into Users(Usernames, Passwords) values(@Usernames, @Passwords)", data.connection);
                insert.Parameters.AddWithValue("@Usernames", userTB.Text);
                insert.Parameters.AddWithValue("@Passwords", Hash.EncryptionString(passTB.Text));
                
                try
                {
                    data.connection.Open();
                    insert.ExecuteNonQuery();
                    Response.Write("Registration completed.");
                    Response.Redirect("Login.aspx");
                }
                catch (Exception ex)
                {
                    Response.Write("An error has occured: " + ex.Message);
                    data.connection.Close();
                }
            }
 
        }

    }
}