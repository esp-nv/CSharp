using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
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

            var stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                stack.Push(elements[i]);
            }

            for (int i = 0; i < s; i++)
            {
               stack.Pop();
            }

            if(stack.Count > 0)
            {
                if (stack.Contains(x))
                {
                    Console.WriteLine("true");
                }
                else 
                {
                    Console.WriteLine(stack.Min()); 
                }
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
