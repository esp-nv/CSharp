using System;

namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int currentNumber = number;
            int sum = 0;

            while (currentNumber > 0)
            {
                int digit = currentNumber % 10;
                number = currentNumber / 10;
                sum += digit;
                currentNumber = number;
            }

            Console.WriteLine(sum);
        }
    }
}
