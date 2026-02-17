using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab07.ParkingLot
{
    internal class Program
    {
        static void Main()
        {
            HashSet<string> set = new HashSet<string>();

            while (true)
            {
                string input = Console.ReadLine().ToLower();

                if (input == "end")
                {
                    break;
                }
                string[] parkingLot = input
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string direction = parkingLot[0];
                string carNumber = parkingLot[1];

                if (direction == "in")
                {
                    set.Add(carNumber);
                }
                else if (direction == "out")
                {
                    set.Remove(carNumber);
                }
            }

            if (set.Count > 0)
            {
                foreach (string parkingLot in set)
                {
                    Console.WriteLine(parkingLot.ToUpper());
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
