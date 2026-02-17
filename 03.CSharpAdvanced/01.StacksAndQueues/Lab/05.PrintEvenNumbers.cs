using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]%2 == 0)
                {
                    queue.Enqueue(input[i]);
                }
            }
            Console.WriteLine(string.Join(", ",queue));
        }

        /*
        Variant: 2
         Queue<int> numbers = new(Console.ReadLine().Split().Select(int.Parse).ToArray());
         Console.WriteLine(string.Join(", ", numbers.Where(x => x % 2 == 0)));
        */
    }
}
