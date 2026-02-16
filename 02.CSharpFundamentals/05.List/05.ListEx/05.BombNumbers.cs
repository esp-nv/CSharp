using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] bombInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int bombNumber = bombInfo[0];
            int bombPower = bombInfo[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    int startIndex = Math.Max(0, i - bombPower);
                    int endIndex = Math.Min(numbers.Count - 1, i + bombPower);

                    for (int j = endIndex; j >= startIndex; j--)
                    {
                        numbers.RemoveAt(j);
                    }
                    i = startIndex - 1; // Adjust index after removal
                }
            }           
            
            Console.WriteLine(numbers.Sum());
        }
    }
}
