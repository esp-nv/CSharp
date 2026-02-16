using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            int countOfMessages = int.Parse(Console.ReadLine());

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            string pattern = @"@(?<planetName>[A-Za-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<attackType>[AD])![^@\-!:>]*->(?<soldiers>\d+)";

            for (int i = 0; i < countOfMessages; i++)
            {
                input = Console.ReadLine();

                int key = input.ToLower().Count(c => c == 's' || c == 't' || c == 'a' || c == 'r');
                StringBuilder decryptedMessage = new StringBuilder();

                foreach (char ch in input)
                {
                    decryptedMessage.Append((char)(ch - key));
                }

                Match match = Regex.Match(decryptedMessage.ToString(), pattern);

                if (match.Success)
                {
                    string planetName = match.Groups["planetName"].Value;
                    string attackType = match.Groups["attackType"].Value;
                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else if (attackType == "D")
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }

            attackedPlanets.Sort();
            destroyedPlanets.Sort();

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");

            foreach (string planet in attackedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");

            foreach (string planet in destroyedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
