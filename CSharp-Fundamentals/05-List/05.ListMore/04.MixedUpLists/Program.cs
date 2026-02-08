using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MixedUpLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> mixedList = new List<int>();
            List<int> border = new List<int>();
            int minLength = Math.Min(firstList.Count, secondList.Count);
            for (int i = 0; i < minLength; i++)
            {
                mixedList.Add(firstList[i]);
                mixedList.Add(secondList[secondList.Count - 1 - i]);
            }
            if (firstList.Count > minLength)
            {
                for (int i = minLength; i < firstList.Count; i++)
                {
                    border.Add(firstList[i]);
                }
            }
            if (secondList.Count > minLength)
            {
                for (int i = 0; i < secondList.Count-firstList.Count ; i++)
                {
                    border.Add(secondList[i]);
                }
            }
            mixedList.Sort();
            border.Sort();
            List<int>result = new List<int>();
            for (int i=0; i < mixedList.Count; i++)
            {
                if (border.Min() < mixedList[i] && border.Max() > mixedList[i])
                {
                    result.Add(mixedList[i]);
                    
                }
                
            }
           // Console.WriteLine(string.Join(" ", mixedList));
            //Console.WriteLine(string.Join(" ", border));
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
