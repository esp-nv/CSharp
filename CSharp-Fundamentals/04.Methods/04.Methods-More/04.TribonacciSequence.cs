using System;

namespace _04.TribonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine();
            }
            else if (n == 1)
            {
                Console.WriteLine(1);
            }
            else if (n == 2)
            {
                Console.WriteLine("1 1");
            }
            else if (n == 3)
            {
                Console.WriteLine("1 1 2");
            }
            else
            {
                int first = 1;
                int second = 1;
                int third = 2;

                Console.Write($"{first} {second} {third} ");

                for (int i = 4; i <= n; i++)
                {
                    int next = first + second + third;
                    Console.Write(next + " ");
                    first = second;
                    second = third;
                    third = next;
                }

                Console.WriteLine();
            }
        }
    }
}
