using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int maxCount = 0;
            int currentCount = 1;
            int maxElement = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {

                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                }
                else
                {

                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        maxElement = numbers[i - 1];
                    }

                    currentCount = 1;
                }
            }

            // Check the last sequence
            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                maxElement = numbers[numbers.Length - 1];
            }

            // Print the result
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(maxElement + " ");
            }


        }
    }
}
