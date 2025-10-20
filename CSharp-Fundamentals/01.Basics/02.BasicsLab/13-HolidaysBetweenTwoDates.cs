using System;
using System.Globalization;

namespace _13_HolidaysBetweenTwoDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(),"d.M.yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

            var holidaysCount = 0;

            for (var i = startDate; i <= endDate; i=i.AddDays(1))
            {

                if (i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                    startDate.AddDays(1);
                }
                
            }
                  
            Console.WriteLine(holidaysCount);
        }
    }
}
