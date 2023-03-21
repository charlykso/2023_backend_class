using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ASP_Example.collective
{
    public class HashPassword
    {
        public static string hashPassword(string password)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            SHA256 sha256 = SHA256.Create();
            byte[] hashBytes = sha256.ComputeHash(passwordBytes);

            string hash = Convert.ToBase64String(hashBytes);

            return hash;
        }
    }
}