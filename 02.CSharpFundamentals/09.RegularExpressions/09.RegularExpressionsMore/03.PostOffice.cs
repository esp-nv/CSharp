using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.PostOffice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            // Разделяме входа на 3 части
            string[] parts = input.Split('|');
            string firstPart = parts[0];
            string secondPart = parts[1];
            string thirdPart = parts[2];

            // 1. Извличаме главните букви от първата част със съвпадащи символи
            string patternFirst = @"([#\$%*&])([A-Z]+)\1";
            Match match = Regex.Match(firstPart, patternFirst);

            string capitalLetters = "";

            if (match.Success)
            {
                capitalLetters = match.Groups[2].Value;
            }

            // 2. Извличаме ASCII кодовете и дължините от втората част
            string patternSecond = @"(?<ascii>\d{2,3}):(?<length>\d{2})";
            MatchCollection matchPairs = Regex.Matches(secondPart, patternSecond);

            // Създаваме речник: буква => дължина
            Dictionary<char, int> letterLengths = new Dictionary<char, int>();

            foreach (Match pair in matchPairs)
            {
                int ascii = int.Parse(pair.Groups["ascii"].Value);
                int length = int.Parse(pair.Groups["length"].Value);
                char letter = (char)ascii;

                if (capitalLetters.Contains(letter))
                {
                    // Дължината включва и първата буква, затова +1
                    if (!letterLengths.ContainsKey(letter))
                        letterLengths[letter] = length + 1;
                }
            }

            // 3. Проверяваме думите от третата част
            string[] words = thirdPart.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (word.Length < 1) continue;

                char start = word[0];

                if (letterLengths.ContainsKey(start) && word.Length == letterLengths[start])
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
