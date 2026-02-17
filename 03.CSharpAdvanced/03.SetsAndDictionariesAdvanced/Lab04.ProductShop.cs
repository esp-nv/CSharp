using System;
using System.Collections.Generic;

namespace Lab04.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            SortedDictionary<string,Dictionary<string,double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            string input;

            while ((input=Console.ReadLine())!= "Revision")
            {
                               
                string[] currInput = input.Split(", ");
                string shop = currInput[0];
                string food = currInput[1];
                double price = double.Parse(currInput[2]);

                if (!shops.ContainsKey(shop)) 
                {
                    shops.Add(shop,new Dictionary<string,double>());
                }

                if (!shops[shop].ContainsKey(food))
                {
                    shops[shop].Add(food,price);
                }                
            }

            foreach (var kvp in shops)
            { 
                var shop = kvp.Key;
                var food = kvp.Value;

                Console.WriteLine($"{shop}->");

                foreach (var item in food)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
