using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Forecast.Encrypt_Decrypt
{
    public class Encrypt
    {
        public static string _Encrypt(string _Encrypt)
        {
            string result = string.Empty;
            byte[] encryted =
            System.Text.Encoding.Unicode.GetBytes(_Encrypt);
            result = Convert.ToBase64String(encryted);
            return result;
        }
        public static string _Decrypt(string _Decrypt)
        {
            string result = string.Empty;
            byte[] decryted =
            Convert.FromBase64String(_Decrypt);
            //result = 
            System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
    }
}
