using System;

namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startChar = char.Parse(Console.ReadLine());
            char endChar = char.Parse(Console.ReadLine());
            PrintCharactersInRange(startChar, endChar);
        }

        private static void PrintCharactersInRange(char startChar, char endChar)
        {
            if (startChar > endChar)
            {
                char temp = startChar;
                startChar = endChar;
                endChar = temp;
            }

            for (char c = (char)(startChar + 1); c < endChar; c++)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();


        }
    }
}
