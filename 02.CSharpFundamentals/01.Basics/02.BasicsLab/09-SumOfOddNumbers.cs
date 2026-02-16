using System;

namespace _09_SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int row = n;
            int sum = 0;
            for (int i = 1; i <= row; i++)
            {

                if (i % 2 != 0)
                {
                    row++;
                    sum += i;
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
