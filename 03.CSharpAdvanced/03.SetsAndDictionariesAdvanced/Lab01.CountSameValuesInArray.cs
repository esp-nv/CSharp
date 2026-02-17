using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab01.CountSameValuesInArray
{
    internal class Program
    {
        static void Main()
        {
            double[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double,int> dic = new Dictionary<double,int>();

            foreach (var num in nums)
            {                
                if (!dic.ContainsKey(num))
                {
                    dic[num] = 0;
                }

                dic[num]++;
            }

            foreach(var num in dic)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}
