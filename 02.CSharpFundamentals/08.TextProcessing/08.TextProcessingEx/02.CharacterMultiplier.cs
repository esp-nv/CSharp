using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string firstString = input[0];
            string secondString = input[1];

            int minLength = Math.Min(firstString.Length, secondString.Length);

            int sum = 0;

            for (int i = 0; i < minLength; i++)
            {
                sum += firstString[i] * secondString[i];
            }

            if (firstString.Length > secondString.Length)
            {
                for (int i = minLength; i < firstString.Length; i++)
                {
                    sum += firstString[i];
                }
            }
            else if (secondString.Length > firstString.Length)
            {
                for (int i = minLength; i < secondString.Length; i++)
                {
                    sum += secondString[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
