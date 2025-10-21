using System;

namespace _05.PrintPartOfTheSCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int firstChar = int.Parse(Console.ReadLine());
            int secondChar = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = firstChar; i <= secondChar; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
