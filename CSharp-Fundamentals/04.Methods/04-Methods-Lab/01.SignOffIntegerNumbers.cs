using System;

namespace _01.SignOffIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSign(int.Parse(Console.ReadLine()));
            // tozi PrinSign(int.Parse(Console.ReadLine()))
            // e ekvivalenten na PrintSign(number) ot predishniq kod
            //number = int.Parse(Console.ReadLine());
            //PrintSign(number);
        }
        static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive. ");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative. ");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero. ");
            }
        }
    }
}
