using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var delivery = Console.ReadLine().Split().Select(int.Parse).ToList();
            var capacity = int.Parse(Console.ReadLine());

            int countBox = 1;
            int sumCurrent = 0;

            delivery.Reverse();

            var stack = new Stack<int>();

            for (int i = 0; i < delivery.Count; i++)
            {
                int stackSum = stack.Sum();
                if (stack.Sum() + delivery[i] <= capacity)
                {
                    stack.Push(delivery[i]);
                }
                else
                {
                    i--;
                    countBox++;
                    stack.Clear();
                }
            }

            Console.WriteLine(countBox);
        }
    }
}
