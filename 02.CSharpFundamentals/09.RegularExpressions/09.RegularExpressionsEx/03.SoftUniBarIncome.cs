using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double totalIncome = 0.0;

            // Регулярен израз за търсене на валидния шаблон
            string pattern = @"%(?<customer>[A-Z][a-z]+)%[^|%$.]*<(?<product>\w+)>[^|%$.]*\|(?<quantity>\d+)\|[^|%$.]*?(?<price>\d+(\.\d+)?)\$";

            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    // Взимаме стойностите от именуваните групи
                    string customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    // Изчисляваме приходите от текущата продажба
                    double income = quantity * price;
                    totalIncome += income;

                    // Извеждаме информацията за продажбата
                    Console.WriteLine($"{customer}: {product} - {income:F2}");
                }
            }

            // Извеждаме общия приход
            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
