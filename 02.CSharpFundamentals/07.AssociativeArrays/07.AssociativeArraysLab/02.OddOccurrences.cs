using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> words = Console.ReadLine()
                .ToLower()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (!counts.ContainsKey(word))
                {
                    counts[word] = 0;
                }
                counts[word]++;
            }

            List<string> oddOccurrences = counts
                .Where(pair => pair.Value % 2 != 0)
                .Select(pair => pair.Key)
                .ToList();

            Console.WriteLine(string.Join(" ", oddOccurrences));
        }
    }
}
