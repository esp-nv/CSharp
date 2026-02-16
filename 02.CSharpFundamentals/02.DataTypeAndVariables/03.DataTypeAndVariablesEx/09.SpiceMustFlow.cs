using System;

namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialYield = int.Parse(Console.ReadLine());

            int totalYield = 0;
            int days = 0;

            // Daily consumption of spice by the miners
            int dailyConsumption = 26;

            while (initialYield >= 100)
            {
                // Subtract daily consumption from the yield
                totalYield += initialYield - dailyConsumption;

                // Increment the number of days
                days++;

                // Decrease the yield by 10 each day
                initialYield -= 10;
            }
            if (totalYield >= 26)
            {
                // Subtract the last day's consumption if there is enough spice
                totalYield -= dailyConsumption;
            }

            Console.WriteLine(days);

            // Output the total yield of spice
            Console.WriteLine(totalYield);
        }
    }
}
