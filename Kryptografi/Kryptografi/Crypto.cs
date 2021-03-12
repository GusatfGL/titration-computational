using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kryptografi
{
    static class Crypto
    {
        static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVXYZÅÄÖabcdefghijklmnopqrstuvxyzåäö.,!?!\"#¤%&/()=?€@£${[]}\'´-_<>|*^";

        public static string Encrypt(string message, int key)
        {
            string encryptedData = "";
            for (int i = 0; i < message.Length; i++)
            {

                encryptedData += IntToChar((CharToInt(message[i]) + key)^2 % alphabet.Length);
            }
            return encryptedData;
        }

        public static string Decrypt(string message, int key)
        {
            string decryptedData = "";
            for (int i = 0; i < message.Length; i++)
            {
                decryptedData += IntToChar(Math.Sqrt())
            }
            return decryptedData;
        }

        public static int CharToInt(char c)
        {
            for (int x = 0; x < alphabet.Length; x++)
            {
                if (c == alphabet[x]) return x;
            }

            return -1;
        }

        public static char IntToChar(int x)
        {
            return alphabet[x % alphabet.Length];
        }
    }
}
