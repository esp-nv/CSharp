using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MatchingBrackets
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }

                if (input[i] == ')')
                {
                    int indexOpenBr = stack.Pop();

                    Console.WriteLine(input.Substring(indexOpenBr, i-indexOpenBr+1));
                }
            }
        }
    }
}

