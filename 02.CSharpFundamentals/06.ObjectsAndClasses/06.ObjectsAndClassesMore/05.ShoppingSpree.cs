using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ShoppingSpree
{
    internal class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public decimal Money { get; set; }
            public List<Product> Products { get; set; }

            public Person(string name, decimal money)
            {
                Name = name;
                Money = money;
                Products = new List<Product>();
            }

            public void BuyProduct(Product product)
            {
                if (Money >= product.Cost)
                {
                    Money -= product.Cost;
                    Products.Add(product);

                    Console.WriteLine($"{Name} bought {product.Name}");
                }
                else
                {
                    Console.WriteLine($"{Name} can't afford {product.Name}");
                }
            }
        }

        public class Product
        {
            public string Name { get; set; }
            public decimal Cost { get; set; }

            public Product(string name, decimal cost)
            {
                Name = name;
                Cost = cost;
            }
        }

        static void Main(string[] args)
        {
           string [] peopleInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
           string[] productsInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            List<Person> people = new List<Person>();

            foreach (var personInfo in peopleInput)
            {
                string[] parts = personInfo.Split('=', StringSplitOptions.RemoveEmptyEntries);
                string name = parts[0];
                decimal money = decimal.Parse(parts[1]);
                people.Add(new Person(name, money));
            }

            List<Product> products = new List<Product>();

            foreach (var productInfo in productsInput)
            {
                string[] parts = productInfo.Split('=', StringSplitOptions.RemoveEmptyEntries);
                string name = parts[0];
                decimal cost = decimal.Parse(parts[1]);
                products.Add(new Product(name, cost));
            }

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] parts = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string personName = parts[0];
                string productName = parts[1];

                Person person = people.FirstOrDefault(p => p.Name == personName);
                Product product = products.FirstOrDefault(p => p.Name == productName);

                if (person != null && product != null)
                {
                    person.BuyProduct(product);
                }
            }
            
            foreach (var person in people)
            {
                if (person.Products.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                    continue;
                }

                Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products.Select(p => p.Name))}");
            }
        }
    }
}
