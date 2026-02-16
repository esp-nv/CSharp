using System;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();
            string encryptedText = string.Empty;

            foreach (char c in input)
            {
                char encryptedChar = (char)(c + 3);
                encryptedText += encryptedChar;
            }

            Console.WriteLine(encryptedText);
        }
    }
}
