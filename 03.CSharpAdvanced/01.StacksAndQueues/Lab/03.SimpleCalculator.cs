using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SimpleCalculator
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().ToList();
          
            var stack = new Stack<string>();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                stack.Push(input[i]);
            }

            while (stack.Count > 1)
            {
                var firstNum = int.Parse(stack.Pop());
                var operation = stack.Pop();
                var secondNum = int.Parse(stack.Pop());

                int sum = 0;
                
                switch (operation)
                {
                    case "+": sum = firstNum + secondNum; break;
                    case "-": sum = firstNum - secondNum; break;
                }
              
                stack.Push(sum.ToString());
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
