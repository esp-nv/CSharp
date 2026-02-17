namespace _02.StackSum
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i<= input.Length-1; i++)
            {
                stack.Push(input[i]);
            }
            string cmd = Console.ReadLine().ToLower();

            while (cmd!= "end")
            {
                var currentInput = cmd.Split().ToList();
                var currentCmd = currentInput[0];

                switch (currentCmd)
                {
                    case "add":
                        stack.Push(int.Parse(currentInput[1]));
                        stack.Push(int.Parse(currentInput[2]));
                        break;
                    case "remove":
                        int count = int.Parse(currentInput[1]);

                        if (stack.Count-1 > count)
                        {
                            for (int j = 0; j < count; j++)
                            {
                                stack.Pop();
                            }
                        }
                        break;
                }

               cmd=Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
