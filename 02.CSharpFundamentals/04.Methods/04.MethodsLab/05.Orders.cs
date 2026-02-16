using System;

namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = GetPrice(product);
            if (price > 0)
            {
                double totalPrice = price * quantity;
                Console.WriteLine($"{totalPrice:F2}");
            }
            else
            {
                Console.WriteLine("Invalid product.");
            }
        }

        private static double GetPrice(string product)
        {
            switch(product.ToLower())
            {
                case "coffee":
                    return 1.50;
                case "water":
                    return 1.00;
                case "coke":
                    return 1.40;
                case "snacks":
                    return 2.00;
                default:
                    Console.WriteLine("Invalid product.");
                    return 0.0;
            }
        }
    }
}
