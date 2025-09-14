using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Cryptography;

namespace Lunar
{
    public static class HashUtils
    {
        public static string GetMD5(string text)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(text);
            return GetMD5(bytes);
        }

        public static string GetMD5(byte[] input)
        {
            using (var md5 = MD5.Create())
            {
                byte[] hashBytes = md5.ComputeHash(input);
                var sb = new System.Text.StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}

