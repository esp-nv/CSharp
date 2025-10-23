﻿using System;

namespace _03.ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                if (i % 2 == 0)
                {
                    firstArray[i] = int.Parse(input[0]);
                    secondArray[i] = int.Parse(input[1]);
                }
                else
                {
                    firstArray[i] = int.Parse(input[1]);
                    secondArray[i] = int.Parse(input[0]);
                }
            }

            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
