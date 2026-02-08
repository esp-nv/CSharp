using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.TakeSkipRope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();
            List<char> letters = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    numbers.Add(int.Parse(input[i].ToString()));
                }
                else
                {
                    letters.Add(input[i]);
                }
            }
            List<int> takeSkip = new List<int>();
            for (int i = 0; i < numbers.Count; i += 2)
            {
                if (i + 1 < numbers.Count)
                {
                    takeSkip.Add(numbers[i]);
                    takeSkip.Add(numbers[i + 1]);
                }
            }
            string result = string.Empty;
            int index = 0;
            for (int i = 0; i < letters.Count; i++)
            {
                if (index < takeSkip.Count)
                {
                    int take = takeSkip[index];
                    int skip = takeSkip[index + 1];
                    result += new string(letters.Skip(i).Take(take).ToArray());
                    i += take + skip - 1; // Adjust index to skip the specified number of characters
                    index += 2; // Move to the next pair of take/skip
                }
                else
                {
                    break; // No more take/skip pairs available
                }
            }
            Console.WriteLine(result);
        }
    }
}
