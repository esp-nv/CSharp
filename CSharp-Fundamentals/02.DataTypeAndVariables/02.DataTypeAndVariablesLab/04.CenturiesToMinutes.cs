using System;

namespace _04.CenturiesToMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            // approximately 365 days, 5 hours, 48 minutes, 45 seconds.
            double oneYear = 365.2422;
            int years = centuries * 100; 
            int days = (int)(years*oneYear);
            double hours = days * 24; 
            double minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
