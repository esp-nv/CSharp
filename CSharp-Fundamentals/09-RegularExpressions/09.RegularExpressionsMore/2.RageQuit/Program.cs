using System;
using System.Collections.Generic;

using System.Text;
using System.Text.RegularExpressions;


namespace _2.RageQuit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([^\d]+)(\d+)";
            MatchCollection matches = Regex.Matches(input, pattern);

            StringBuilder rageMessage = new StringBuilder();
            string uniqueSymbols = ""; // Тук ще пазим уникалните символи

            foreach (Match match in matches)
            {
                string text = match.Groups[1].Value.ToUpper(); // Превръщаме в главни букви
                int repeatCount = int.Parse(match.Groups[2].Value);

                // Добавяме текста N пъти
                for (int i = 0; i < repeatCount; i++)
                {
                    rageMessage.Append(text);
                }
            }

            // След като сме изградили пълното съобщение, проверяваме за уникални символи
            string result = rageMessage.ToString();

            foreach (char ch in result)
            {
                // Проверяваме дали вече не сме срещали символа (без hashset)
                if (!uniqueSymbols.Contains(ch))
                {
                    uniqueSymbols += ch;
                }
            }

            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Length}");
            Console.WriteLine(result);
        }
    }
}
