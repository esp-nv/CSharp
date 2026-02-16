using System;

namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(SmallestOfThree(firstNumber, secondNumber, thirdNumber));
        }

        private static int SmallestOfThree(int firstNumber, int secondNumber, int thirdNumber)
        {
            int smallestNumber = firstNumber;
            if (secondNumber < smallestNumber)
            {
                smallestNumber = secondNumber;
            }
            if (thirdNumber < smallestNumber)
            {
                smallestNumber = thirdNumber;
            }
            return smallestNumber;
        }
    }
}
