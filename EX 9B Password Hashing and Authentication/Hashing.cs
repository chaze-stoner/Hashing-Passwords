using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Runtime.InteropServices.ComTypes;

namespace EX_9B_Password_Hashing_and_Authentication
{
    class Hashing
    {

        /******************************************************
         * Used to create a sha512 hash of the players password
         ******************************************************/
        public static string PasswordHash(string strings)
        {
            using SHA512 sha512 = SHA512.Create();
            var hash = Encoding.UTF8.GetBytes(strings);
            var T = sha512.ComputeHash(hash);

            StringBuilder builder = new StringBuilder(128);
            foreach (var item in T)

                builder.Append(item.ToString("x2"));

            return builder.ToString();
        }

    }
}
