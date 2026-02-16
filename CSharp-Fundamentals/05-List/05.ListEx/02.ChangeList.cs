using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] parts = command.Split(' ');

                if (parts[0] == "Delete")
                {
                    int elementToRemove = int.Parse(parts[1]);
                    numbers.RemoveAll(n => n == elementToRemove);
                }
                else if (parts[0] == "Insert")
                {
                    int elementToInsert = int.Parse(parts[1]);
                    int position = int.Parse(parts[2]);
                    numbers.Insert(position, elementToInsert);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
