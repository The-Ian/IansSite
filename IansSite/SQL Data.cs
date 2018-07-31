using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace IansSite
{
    public class SQL_Data : IDisposable
    {
        public SqlConnection connection;

        public SQL_Data()
        {
            string SQLConn = WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            connection = new SqlConnection(SQLConn);
        }

        public SQL_Data(string ConnectionStr)
        {
            connection = new SqlConnection(ConnectionStr);
        }

        public string VerifyUser(string username)
        {
            string returnValue = "";

            connection.Open();
            SqlCommand SqlUserVerify = new SqlCommand("spNoDupeUsers", connection);
            SqlUserVerify.CommandType = CommandType.StoredProcedure;
            SqlUserVerify.Parameters.AddWithValue("@Username", username);

            DataTable UsersandPass = new DataTable();
            SqlDataAdapter sqlData = new SqlDataAdapter(SqlUserVerify);

            sqlData.Fill(UsersandPass);

            if (UsersandPass.Rows.Count != 0)
            {
                returnValue = "User already exists.";
            }

            else
            {
                returnValue = "User is available.";
            }

            return returnValue;
        }

        public string Verification(string Username, string Password)
        {
            string returnValue = "";

            connection.Open();
            SqlCommand SqlVerification = new SqlCommand("spVerification", connection);
            SqlVerification.CommandType = CommandType.StoredProcedure;
            SqlVerification.Parameters.AddWithValue("@Username", Username);

            DataTable UsersandPass = new DataTable();
            SqlDataAdapter sqlData = new SqlDataAdapter(SqlVerification);

            sqlData.Fill(UsersandPass);

            if (UsersandPass.Rows.Count == 0)
            {
                returnValue = "User doesn't exist.";
            }

            else
            {
                if (UsersandPass.Rows[0]["Passwords"].ToString() == Hash.EncryptionString(Password))
                {
                    returnValue = "Proceed";
                }
                else
                {
                    returnValue = "Try again.";
                }
            }
            return returnValue;
        }

        public void LogWrite(string LogMessage)
        {
            StreamWriter logOutput = new StreamWriter(HttpRuntime.AppDomainAppPath + "\\Resources\\AppLog.txt", true);
            logOutput.WriteLine(DateTime.Now.ToString() + ":  " + LogMessage);
            logOutput.Close();           
        }

        public void Dispose()
        {
            connection.Close();
            connection = null;
        }

    }
}