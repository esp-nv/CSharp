using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string text = Console.ReadLine();

            foreach (string word in bannedWords)
            {
                string replacement = new string('*', word.Length);
                text = text.Replace(word, replacement);
            }
            Console.WriteLine(text);
        }
    }
}
