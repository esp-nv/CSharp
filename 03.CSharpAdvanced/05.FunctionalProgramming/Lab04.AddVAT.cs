using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab04.AddVAT
{
    internal class Program
    {
        static void Main()
        {
            List<decimal> list = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .Select(x => x * 1.20m)
                .ToList();

            foreach (decimal x in list)
            {
                Console.WriteLine(x.ToString("f2"));
            }

            //var2

            //decimal[] prices = Console.ReadLine()
            //  .Split(", ")
            //  .Select(decimal.Parse)
            //  .ToArray();

            //Func<decimal, decimal> calculatingVAT = x => x * 0.2m+x; //x * 1.20m

            //foreach (decimal price in prices)
            //{
            //    Console.WriteLine(calculatingVAT(price).ToString("f2"));
            //}


        }
    }
}
