using System;
using System.Globalization;
namespace _03_GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double startBalance = balance;
            double spentMoney = 0;
            string input = "";
            bool isFound = false;
            bool isGameTime = false;

            while ((input = Console.ReadLine()) != "Game Time")
            {
                double price = 0;

                switch (input)
                {
                    case "OutFall 4":
                        price = 39.99;
                        isFound = true;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        isFound = true;
                        break;
                    case "Zplinter Zell":
                        isFound = true;
                        price = 19.99;
                        break;
                    case "Honored 2":
                        isFound = true;
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        isFound = true;
                        price = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        isFound = true;
                        price = 39.99; break;
                    default:
                        Console.WriteLine("Not Found");
                        isFound = false;
                        break;
                }

                if (balance >= price && isFound == true)
                {
                    balance -= price;
                    spentMoney += price;
                    Console.WriteLine($"Bought {input}");

                }
                else if (balance < price && isFound == true)
                {
                    Console.WriteLine("Too Expensive");
                }

                if (isGameTime == true && balance == 0)
                {
                    break;
                }

            }

            if (balance != 0)
            {
                Console.WriteLine($"Total spent: ${spentMoney:f2}. Remaining: ${balance:f2}");
            }

            if (balance == 0)
            {
                Console.WriteLine("Out of money!");
                isGameTime = true;
            }
        }
    }
}
