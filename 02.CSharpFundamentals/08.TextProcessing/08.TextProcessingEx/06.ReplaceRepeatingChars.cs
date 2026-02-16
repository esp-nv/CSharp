using System;

namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = string.Empty;

            char previousChar = '\0';
          
            foreach (char currentChar in input)
            {
                if (currentChar != previousChar)
                {
                    result += currentChar;
                    previousChar = currentChar;
                }
            }

            Console.WriteLine(result);
        }
    }
}
