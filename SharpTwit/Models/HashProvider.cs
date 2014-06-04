using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Flutter.Models
{
    public class HashProvider
    {
        public string GetMD5Hash(string plaintext)
        {
            MD5CryptoServiceProvider MD5provider = new MD5CryptoServiceProvider(); // Hashing algorith
            byte[] hasedvalue = MD5provider.ComputeHash(Encoding.Default.GetBytes(plaintext)); // takes a byte array, so convert string to byte array
            StringBuilder str = new StringBuilder(); // used to turn the resultant byte array back to a string
            for (int counter = 0; counter < hasedvalue.Length; counter++) // loop over byte array, building up the string
            {
                str.Append(hasedvalue[counter].ToString("x2"));
            }
            return str.ToString();
        }
    }
}