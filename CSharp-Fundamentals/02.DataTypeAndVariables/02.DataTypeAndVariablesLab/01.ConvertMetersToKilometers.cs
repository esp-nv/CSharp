using System;

namespace _01.ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            double convertMetersToKm = meters / 1000d;

            Console.WriteLine($"{convertMetersToKm:f2}");
        }
    }
}
