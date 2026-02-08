using System;
using System.Dynamic;

namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int nubrer2 = int.Parse(Console.ReadLine());
            Console.WriteLine(GetResult(number, operation, nubrer2)); 
        }

        private static int GetResult(int number, char operation, int nubrer2)
        {
            int result = 0;
            switch (operation)
            {
                case '+':
                    result = number + nubrer2;
                    break;
                case '-':
                    result = number - nubrer2;
                    break;
                case '*':
                    result = number * nubrer2;
                    break;
                case '/':
                    if (nubrer2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                        break;
                    }
                    result = number / nubrer2;
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
            return result;
        }
    }
}
