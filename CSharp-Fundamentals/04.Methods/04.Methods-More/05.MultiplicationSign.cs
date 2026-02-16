using System;

namespace _05.MultiplicationSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            PrintMultiplicationSign(a, b, c);

            if (PrintMultiplicationSign(a, b, c) > 0)
            {
                Console.WriteLine("positive");
            }
            else if (PrintMultiplicationSign(a, b, c) < 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("zero");
            }
        }

        private static int PrintMultiplicationSign(int a, int b, int c)
        {
            return a * b * c; 
        }
    }
}
