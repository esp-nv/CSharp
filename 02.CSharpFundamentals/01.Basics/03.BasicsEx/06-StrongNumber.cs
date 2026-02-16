using System;

namespace _06_StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int originalNum = number;
            int sum = 0;

            while (number > 0)
            {
                int fac = 1;
                int lastDigth = number % 10;
                number /= 10;

                for (int i = 1; i <= lastDigth; i++)
                {
                    fac *= i;
                }
                sum += fac;

            }

            if (sum == originalNum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
