using System;

namespace _02.PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int[] arr = new int[numbers];

            for (int i = 0; i < numbers; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = numbers - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
