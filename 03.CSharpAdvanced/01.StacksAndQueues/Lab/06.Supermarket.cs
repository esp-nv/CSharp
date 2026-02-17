using System;
using System.Collections.Generic;

namespace _06.Supermarket
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Queue<string> queue = new Queue<string>();

            while (input != "End")
            {
                var currentInput = input;

                if(input != "Paid")
                {
                    queue.Enqueue(currentInput);
                }
                else if(input == "Paid")
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }

               input = Console.ReadLine();
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
