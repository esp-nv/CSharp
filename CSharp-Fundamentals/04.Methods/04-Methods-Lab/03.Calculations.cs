using System;
using System.ComponentModel;

namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            switch (input)
            {
                case "add":
                    Add(number1, number2);
                    break;
                case "subtract":
                    Subtract(number1, number2);
                    break;
                case "multiply":
                    Multiply(number1, number2);
                    break;
                case "divide":
                    Divide(number1, number2);
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }
        }

        static void Divide(int a, int b)
        {
            if (b != 0)
                Console.WriteLine((double)a / b);
            else
                Console.WriteLine("Cannot divide by zero.");
        }

        static void Multiply(int a, int b)
        {
            Console.WriteLine(a*b);
        }

        static void Subtract(int a, int b)
        {
            Console.WriteLine(a-b);
        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
    }
}
