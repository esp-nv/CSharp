using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var elements = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int n = input[0];
            int s = input[1];
            int x = input[2];

            var queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(elements[i]);
            }

            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count > 0)
            {
                if (queue.Contains(x))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
