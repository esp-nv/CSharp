using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.MorseCodeTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, char> morseCodeDictionary = new Dictionary<string, char>
            {
                { ".-", 'A' }, { "-...", 'B' }, { "-.-.", 'C' }, { "-..", 'D' },
                { ".", 'E' }, { "..-.", 'F' }, { "--.", 'G' }, { "....", 'H' },
                { "..", 'I' }, { ".---", 'J' }, { "-.-", 'K' }, { ".-..", 'L' },
                { "--", 'M' }, { "-.", 'N' }, { "---", 'O' }, { ".--.", 'P' },
                { "--.-", 'Q' }, { ".-.", 'R' }, { "...", 'S' }, { "-", 'T' },
                { "..-", 'U' }, { "...-", 'V' }, { ".--", 'W' }, { "-..-", 'X' },
                { "-.--", 'Y' }, { "--..", 'Z' }
            };
            
            string input = Console.ReadLine();

            StringBuilder morseCodeMessage = new StringBuilder();
            string[] morseCodeWords = input.Split('|');

            foreach (string morseCodeWord in morseCodeWords)
            {
                string[] morseCodeChars = morseCodeWord.Trim().Split(' ');

                foreach (string morseCodeChar in morseCodeChars)
                {
                    if (morseCodeDictionary.ContainsKey(morseCodeChar))
                    {
                        morseCodeMessage.Append(morseCodeDictionary[morseCodeChar]);
                    }                    
                }
                morseCodeMessage.Append(' '); // Add space between words
            }

            // Trim the last space
            if (morseCodeMessage.Length > 0)
            {
                morseCodeMessage.Length--; // Remove the last space
            }

            Console.WriteLine(morseCodeMessage.ToString().Trim());
        }
    }
}
