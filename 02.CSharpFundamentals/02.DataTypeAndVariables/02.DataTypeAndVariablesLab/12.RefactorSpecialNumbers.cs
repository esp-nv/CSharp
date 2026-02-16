using System;

namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            int sum = 0;

            // int takova = 0;
            bool isSpecialNumber = false;

            for (int i = 1; i <= inputNum; i++)
            {
                int currentNum = i;

                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }

                isSpecialNumber = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine("{0} -> {1}", currentNum, isSpecialNumber);

                sum = 0;
                i = currentNum;
            }

        }
    }
}
