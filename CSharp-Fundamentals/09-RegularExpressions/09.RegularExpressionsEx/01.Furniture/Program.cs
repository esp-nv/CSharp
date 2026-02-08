using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;



namespace _01.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<string> boughtFurniture = new List<string>();
            double totalMoneySpent = 0.0;

            // Регулярен израз за търсене на валидния шаблон
            string pattern = @">>(?<name>[A-Za-z\s]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)";

            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    // Взимаме стойностите от именуваните групи
                    string name = match.Groups["name"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    boughtFurniture.Add(name);
                    totalMoneySpent += price * quantity;
                }
            }

            // Извеждаме резултатите
            Console.WriteLine("Bought furniture:");
            foreach (string item in boughtFurniture)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {totalMoneySpent:F2}");
        }
    }
}
