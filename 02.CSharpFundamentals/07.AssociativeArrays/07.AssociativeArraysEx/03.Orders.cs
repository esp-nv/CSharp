using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Orders
{   
    internal class Program
    {
        class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }

            public Product(string name, decimal price, decimal quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }

            public void Update(decimal price, decimal quantity)
            {
                Price = price;
                Quantity += quantity;
            }

            public override string ToString()
            {
                return $"{Name} -> {Price * Quantity:F2}";
            }
        }

        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string productName = tokens[0];
                decimal price = decimal.Parse(tokens[1]);
                decimal quantity = decimal.Parse(tokens[2]);

                if (!products.ContainsKey(productName))
                {
                    products[productName] = new Product(productName, price, quantity);
                }
                else
                {
                    products[productName].Update(price, quantity);
                }
                input = Console.ReadLine();
            }

            foreach (var product in products.Values)
            {
                Console.WriteLine(product);
            }
        }
    }
}
