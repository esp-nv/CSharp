using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] parts = command.Split(' ');
                string name = parts[0];
                //is going to party
                if (parts.Length == 3 && parts[2] == "going!")
                {
                    if (!guests.Contains(name))
                    {
                        guests.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
                //is not going to party
                else if (parts.Length == 4 && parts[2] == "not" && parts[3] == "going!")
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }

}
