using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (currentChar == ' ')
                {
                    continue; // Skip spaces
                }
                else if (charCount.ContainsKey(currentChar))
                {
                    charCount[currentChar]++;
                }
                else
                {
                    charCount[currentChar] = 1;
                }
            }
            foreach (var pair in charCount)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}

