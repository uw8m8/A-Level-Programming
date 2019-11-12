using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caeser_Cipher_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string Message = encrypt("Cheese Please!", 15);
            Console.WriteLine(Message);
            Console.WriteLine();
            Console.WriteLine(decrypt(Message, 15));
            Console.ReadLine();
        }

        static string decrypt(string cipherText, int shiftKey)
        {
            char[] plainArray = cipherText.ToCharArray();
            int ASCIILetterValue = 0;

            for (int i = 0; i < plainArray.Length; i++)
            {
                ASCIILetterValue = (int)plainArray[i];

                if (Char.IsUpper(plainArray[i]))
                {
                    ASCIILetterValue = ASCIILetterValue - 65;
                    ASCIILetterValue = ASCIILetterValue - shiftKey;
                    ASCIILetterValue = ASCIILetterValue + 26;
                    ASCIILetterValue = ASCIILetterValue % 26;
                    ASCIILetterValue = ASCIILetterValue + 65;
                    plainArray[i] = (char)ASCIILetterValue;
                }
                else if (Char.IsLower(plainArray[i]))
                {
                    ASCIILetterValue = ASCIILetterValue - 97;
                    ASCIILetterValue = ASCIILetterValue - shiftKey;
                    ASCIILetterValue = ASCIILetterValue + 26;
                    ASCIILetterValue = ASCIILetterValue % 26;
                    ASCIILetterValue = ASCIILetterValue + 97;
                    plainArray[i] = (char)ASCIILetterValue;
                }
            }
            return new string(plainArray);
        }

        static string encrypt (string plaintext, int shiftKey)
        {
            char[] cipherArray = plaintext.ToCharArray();
            int ASCIILetterValue = 0;

            for (int i = 0; i < cipherArray.Length; i++)
            {
                ASCIILetterValue = (int) cipherArray[i];

                if (Char.IsUpper(cipherArray[i]))
                {
                    ASCIILetterValue = ASCIILetterValue - 65;
                    ASCIILetterValue = ASCIILetterValue + shiftKey;
                    ASCIILetterValue = ASCIILetterValue % 26;
                    ASCIILetterValue = ASCIILetterValue + 65;
                    cipherArray[i] = (char) ASCIILetterValue;
                }
                else if (Char.IsLower(cipherArray[i]))
                {
                    ASCIILetterValue = ASCIILetterValue - 97;
                    ASCIILetterValue = ASCIILetterValue + shiftKey;
                    ASCIILetterValue = ASCIILetterValue + 26;
                    ASCIILetterValue = ASCIILetterValue % 26;
                    ASCIILetterValue = ASCIILetterValue + 97;
                    cipherArray[i] = (char)ASCIILetterValue;
                }
            }
            return new string (cipherArray);
        }

    }
}
