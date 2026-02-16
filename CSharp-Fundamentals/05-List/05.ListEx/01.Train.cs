using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            List<int> train = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            
            int maxCapacity = int.Parse(Console.ReadLine());

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] parts = command.Split(' ');

                if (parts[0] == "Add")
                {
                    int wagon = int.Parse(parts[1]);
                    train.Add(wagon);
                }
                else
                {
                    int passengers = int.Parse(parts[0]);

                    for (int i = 0; i < train.Count; i++)
                    {
                        if (train[i] + passengers <= maxCapacity)
                        {
                            train[i] += passengers;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", train));
        }
    }
}
