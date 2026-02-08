using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";
            var input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, pattern);
            var matchesList = new List<string>();
            foreach (Match match in matches)
            {
                matchesList.Add(match.Value);
            }
            Console.Write(string.Join(", ", matchesList));
                      
        }
    }
}
