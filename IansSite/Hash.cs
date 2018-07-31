using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace IansSite
{
    public class Hash
    {
        static public string EncryptionString(string input)
        {
            string returnValue = "";
            byte[] hashData;

            using (MD5 hashStr = MD5.Create())

                try
                {
                    hashData = hashStr.ComputeHash(Encoding.UTF8.GetBytes(input));

                    for (int i = 0; i < hashData.Length; i++)
                    {
                        returnValue += hashData[i].ToString("X2");
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            return returnValue;
        }
    }
}