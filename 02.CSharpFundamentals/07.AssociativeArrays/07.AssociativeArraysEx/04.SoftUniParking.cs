using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> parking = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string action = command[0];
                string username = command[1];

                if (action == "register")
                {
                    string licensePlate = command[2];

                    if (!parking.ContainsKey(username))
                    {
                        parking[username] = licensePlate;

                        Console.WriteLine($"{username} registered {licensePlate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parking[username]}");
                    }
                }
                else if (action == "unregister")
                {
                    if (parking.ContainsKey(username))
                    {
                        parking.Remove(username);

                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }

            foreach (var entry in parking)
            {
                Console.WriteLine($"{entry.Key} => {entry.Value}");
            }
        }
    }
}
