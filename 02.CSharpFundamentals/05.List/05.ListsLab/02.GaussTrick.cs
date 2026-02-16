using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();

            List<int> result = new List<int>();

            int count = numbers.Count;

            for (int i = 0; i < count / 2; i++)
            {
                result.Add(numbers[i] + numbers[count - 1 - i]);
                numbers.RemoveAt(count - 1 - i);
            }

            if (count % 2 != 0)
            {
                result.Add(numbers[count / 2]);
            }
          
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
