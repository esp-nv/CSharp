using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('|').ToList();
            input.Reverse();
          
            List<int> result = new List<int>();

            foreach (var item in input)
            {
                List<int> numbers = item.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                result.AddRange(numbers);
            }
           
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
