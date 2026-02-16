using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.AsciiSumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startChar = char.Parse(Console.ReadLine());
            char endChar = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (currentChar > startChar && currentChar < endChar)
                {
                    sum += currentChar;
                }
            }
            if (sum == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}
