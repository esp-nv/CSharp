using System;
using System.Collections.Generic;
using System.Linq;

namespace _00.Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('|').ToList();
            input.Reverse(); // Reverse the list to process from the last element to the first
            List<int> result = new List<int>();

            foreach (var item in input)
            {
               
                result.AddRange(item.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
