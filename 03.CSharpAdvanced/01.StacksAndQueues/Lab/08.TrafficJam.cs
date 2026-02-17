using System;
using System.Collections.Generic;

namespace _08.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countCarPassed = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            string command = Console.ReadLine();
            
            int carPassed = 0;

            while (command != "end")
            {
                string currentInput = command;

                if (command == "green")
                {
                    for (int i = 1; i <= countCarPassed && queue.Count != 0; i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        carPassed++;
                    }
                }
                else
                {
                    queue.Enqueue(currentInput);
                }

                command = Console.ReadLine();                
            }

            Console.WriteLine($"{carPassed} cars passed the crossroads.");
        }
    }
}
