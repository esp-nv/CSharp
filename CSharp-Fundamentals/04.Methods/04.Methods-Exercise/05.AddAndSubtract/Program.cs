using System;

namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintResult(firstNumber, secondNumber, thirdNumber));
        }
        
        private static int PrintResult(int firstNumber, int secondNumber, int thirdNumber)
        {
            return SumResult(firstNumber, secondNumber) - thirdNumber;

        }

        private static int SumResult(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
