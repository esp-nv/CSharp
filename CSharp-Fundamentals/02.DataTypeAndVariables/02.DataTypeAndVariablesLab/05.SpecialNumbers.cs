using System;

namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                int currNumber = i;

                while (currNumber > 0)
                {
                    int lastDigit = currNumber % 10;
                    currNumber = (currNumber - lastDigit) / 10;
                    sum += lastDigit;

                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
                sum = 0;
            }

        }
    }
}
