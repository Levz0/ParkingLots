using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ип.Connect
{
    static class md5
    {
        public static string hashPassword(string password)
        {
            MD5 md5 = MD5.Create();

            byte[] hash = md5.ComputeHash(Encoding.UTF32.GetBytes(password));


            StringBuilder sb = new StringBuilder();

            foreach (var c in hash)
            {
                sb.Append(c.ToString("X2"));
            }

            return Convert.ToString(sb);
            
        }
    }
}
