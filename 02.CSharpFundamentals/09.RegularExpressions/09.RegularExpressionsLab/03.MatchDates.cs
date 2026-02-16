using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(?<day>\d{2})(?<sep>[.\-/])(?<month>[A-Z][a-z]{2})(\k<sep>)(?<year>\d{4})";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
