using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace IansSite
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Init(object sender, EventArgs e)
        {
            SQL_Data data = new SQL_Data();
            data.LogWrite("Application has initialized");
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            SQL_Data data = new SQL_Data();
            data.LogWrite("Application has started");
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            SQL_Data data = new SQL_Data();
            data.LogWrite("Session has started");
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            SQL_Data data = new SQL_Data();
            data.LogWrite("Application has a new request");
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            SQL_Data data = new SQL_Data();
            data.LogWrite("An error has occured with the application");
        }

        protected void Session_End(object sender, EventArgs e)
        {
            SQL_Data data = new SQL_Data();
            data.LogWrite("Session has ended");
        }

        protected void Application_End(object sender, EventArgs e)
        {
            SQL_Data data = new SQL_Data();
            data.LogWrite("Application has ended");
        }
    }
}