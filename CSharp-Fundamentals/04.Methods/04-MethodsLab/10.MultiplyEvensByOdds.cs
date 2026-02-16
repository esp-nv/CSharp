using System;

namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int evenSum = GetEvenSum(number);
            int oddSum = GetOddSum(number);
            Console.WriteLine(MultiplyEvenAndOddSums(evenSum,oddSum));

        }
        private static int GetEvenSum(int number)
        {
            int evenSum = 0;
         
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    evenSum += digit;
                }
                number /= 10;
            }
            return evenSum;
        }
        private static int GetOddSum(int number)
        {
            int oddSum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    oddSum += digit;
                }
                number /= 10;
            }
            return oddSum;
        }
        private static int MultiplyEvenAndOddSums(int evenSum, int oddSum)
        {
            return evenSum * oddSum;

        }
        
    }
}
