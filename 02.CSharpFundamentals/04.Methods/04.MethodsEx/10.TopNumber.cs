using System;

namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsTopNumber(int i)
        {
            int sum = 0;
            int digitCount = 0;
            int number = i;

            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;

                if (digit % 2 != 0)
                {
                    digitCount++;
                }

                number /= 10;
            }

            return sum % 8 == 0 && digitCount > 0;
        }
    }
}
