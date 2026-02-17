using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaxiAndMiniElement
{
    internal class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                int cmd = input[0];

                switch (cmd)
                {
                    case 1: 
                        stack.Push(input[1]); 
                        break;
                    case 2:
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                        break;
                    case 3:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                    case 4:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
