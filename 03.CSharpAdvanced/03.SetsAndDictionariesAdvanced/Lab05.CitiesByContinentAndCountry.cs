using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab05.CitiesByContinentAndCountry
{
    internal class Program
    {
        static void Main()
        {
            //Create a program that reads continents, countries and their cities put them in a nested dictionary and prints them.
            int row = int.Parse(Console.ReadLine());

            //continents -> countries -> cities
            //nested dictionary (string -> (Dictionary -> List<string>)) .
            Dictionary<string, Dictionary<string, List<string>>> dic = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < row; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!dic.ContainsKey(continent))
                {
                    dic.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!dic[continent].ContainsKey(country))
                {
                    dic[continent].Add(country, new List<string>());
                }

                dic[continent][country].Add(city);
            }

            foreach (var kvp in dic)
            {
                var continents = kvp.Key;
                var countries = kvp.Value;

                Console.WriteLine($"{continents}:");

                foreach (var item in countries)
                {
                    var country = item.Key;
                    var city = item.Value;

                    Console.WriteLine($"  {country} -> {string.Join(", ", city)}");
                }
            }
        }
    }
}
