using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, long> resources = new Dictionary<string, long>();
            while (input != "stop")
            {
                long quantity = long.Parse(Console.ReadLine());
                if (!resources.ContainsKey(input))
                {
                    resources.Add(input, 0);
                }
                
                if (resources.ContainsKey(input))
                {
                    resources[input] += quantity;
                }
                else
                {
                    resources[input] = quantity;
                }
                input = Console.ReadLine();
            }
            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
