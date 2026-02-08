using System;

namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int vowelsCount = CountVowels(input);
        }

        private static int CountVowels(string input)
        {
            int count = 0;
            foreach (char c in input.ToLower())
            {               
               if ("aeiou".Contains(c))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            return count;
        }
    }
}
