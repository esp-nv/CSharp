using System;
using System.Linq;

namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(' ');

            int[] numbers = new int[strings.Length];

            for (int i = 0; i < strings.Length; i++)
            {
                numbers[i] = int.Parse(strings[i]);
            }

            int[] topIntegers = new int[numbers.Length];

            int topCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isTopInteger = true;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] <= numbers[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    topIntegers[topCount++] = numbers[i];
                }
            }

            // Print the top integers
            for (int i = 0; i < topCount; i++)
            {
                Console.Write(topIntegers[i]);

                if (i < topCount - 1)
                {
                    Console.Write(" ");
                }
            }

            // Print a new line at the end
            Console.WriteLine();
        }
    }
}
