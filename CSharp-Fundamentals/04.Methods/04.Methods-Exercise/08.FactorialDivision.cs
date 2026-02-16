using System;

namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
          
            Console.WriteLine($"{FactorialDivision(firstNumber,secondNumber):F2}");
        }
        
        static double FactorialDivision(int first, int second )
        {
            double firstFactorial = CalculateFactorial(first);
            double secondFactorial = CalculateFactorial(second);
          
            return firstFactorial / secondFactorial;
        }

        static double CalculateFactorial(int number)
        {
           double result = 1;
          
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            } 
            return result;
        }
    }
}
