using System;
using System.Linq;

namespace Lab03.Largest3Numbers
{
    internal class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] sorted = input.OrderByDescending(x => x)
                .ToArray();

            Console.WriteLine(string.Join(" ", sorted.Take(3)));
        }
    }
}
