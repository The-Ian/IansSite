using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IansSite
{
    public partial class Calculator : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Login.Visible = (Session["User"] == null);

            if (Session["User"] != null)
            {
                User.Visible = true;
                User.Text = "Hello " + Session["User"];
            }

            if (!IsPostBack)
            {
                ViewState["Number"] = "0"; 
            }

            resultTB.Text = ViewState["Number"].ToString();
        }

        
        protected void Button1_Click(object sender, EventArgs e)
        {
            double CalcNumber;

            try
            {
                if (DropDownList1.SelectedValue == "Add")
                {
                    CalcNumber = Convert.ToDouble(resultTB.Text) +
                       Convert.ToDouble(entryTB.Text);
                    ViewState["Number"] = CalcNumber.ToString();
                }

                else if (DropDownList1.SelectedValue == "Subtract")
                {
                    CalcNumber = Convert.ToDouble(resultTB.Text) -
                       Convert.ToDouble(entryTB.Text);
                    ViewState["Number"] = CalcNumber.ToString();
                }

                else if (DropDownList1.SelectedValue == "Divide")
                {
                    CalcNumber = Convert.ToDouble(resultTB.Text) /
                       Convert.ToDouble(entryTB.Text);
                    ViewState["Number"] = CalcNumber.ToString();
                }

                else
                {
                    CalcNumber = Convert.ToDouble(resultTB.Text) *
                       Convert.ToDouble(entryTB.Text);
                   ViewState["Number"] = CalcNumber.ToString();
                }
            }
            catch (FormatException)
            {
               Response.Write("Please input a number.");
            }

            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                Session.Clear();
                Response.Redirect("Login.aspx");
            }
        }
    }
}