using System;

namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
          
            while (input != "END")
            {
                int number = int.Parse(input);
              
                Console.WriteLine(IsPalindrome(number));
              
                input = Console.ReadLine();
            }
        }

        private static bool IsPalindrome(int number)
        {
            int originalNumber = number;
            int reversedNumber = 0;
          
            while (number > 0)
            {
                int digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit;
                number /= 10;
            }
          
            return originalNumber == reversedNumber;
        }
    }
}
