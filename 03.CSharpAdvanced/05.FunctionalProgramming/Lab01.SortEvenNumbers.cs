using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab01.SortEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .Where(x => x %2 == 0)
                .OrderBy(x => x)
                .ToList();
            Console.WriteLine(string.Join(", ",number));
        }
    }
}
