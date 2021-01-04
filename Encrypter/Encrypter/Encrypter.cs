using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypter
{
    class Encrypter
    {
        public static string OriginalAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string EncryptionAlphabet = "DEFGHIJKLMNOPQRSTUVWXYZABC";


        public static string Encrypt(string originalString)
        {
            string newString = "";

            foreach (Char item in originalString)
            { 
                foreach(char letter in OriginalAlphabet)
                {
                    if (item == letter)
                    {
                        int alphIndex = OriginalAlphabet.IndexOf(letter);
                        newString = newString + (EncryptionAlphabet.ElementAt(alphIndex));
                    }
                }
            }

            return newString;
        }

        public static string Decrypt(string originalString)
        {
            string decryptedString = "";

            foreach (Char item in originalString)
            {
                foreach (char letter in EncryptionAlphabet)
                {
                    if (item == letter)
                    {
                        int alphIndex = EncryptionAlphabet.IndexOf(letter);
                        decryptedString = decryptedString + (OriginalAlphabet.ElementAt(alphIndex));
                    }
                }
            }

            return decryptedString;
        }
    }
}
