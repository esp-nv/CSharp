using System;

namespace _04.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                PrintTriangle(1,i);
            }
            for (int i = count - 1; i >= 0; i--)
            {
                PrintTriangle(1, i);
            }
        }
        static void PrintTriangle(int start, int end)
        {

            for (int j = start; j <= end; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();

        }
    }
}
