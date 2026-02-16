using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(word => word.Length % 2 == 0)
                .ToList();
          
            foreach (string word in words)
                Console.WriteLine(word);
        }
    }
}
