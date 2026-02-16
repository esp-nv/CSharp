using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.DigitsLettersАndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();
            List<char> digits = new List<char>();
            List<char> letters = new List<char>();
            List<char> others = new List<char>();
            foreach (char ch in input)
            {
                if (char.IsDigit(ch))
                {
                    digits.Add(ch);
                }
                else if (char.IsLetter(ch))
                {
                    letters.Add(ch);
                }
                else
                {
                    others.Add(ch);
                }
            }
            Console.WriteLine(string.Join("", digits));
            Console.WriteLine(string.Join("", letters));
            Console.WriteLine(string.Join("", others));
        }
    }
}
