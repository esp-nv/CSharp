using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<double> results = new List<double>();

            foreach (string item in input)
            {
                double number = ExtractNumber(item);
                char firstLetter = item[0];
                char lastLetter = item[item.Length - 1];
                number = AdjustNumber(number, firstLetter, lastLetter);
                results.Add(number);
            }

            Console.WriteLine($"{results.Sum():F2}");
        }

        private static double AdjustNumber(double number, char firstLetter, char lastLetter)
        {            
            int firstLetterPosition = char.ToLower(firstLetter) - 'a' + 1;
            int lastLetterPosition = char.ToLower(lastLetter) - 'a' + 1;

            if (char.IsUpper(firstLetter))
            {
                number /= firstLetterPosition;
            }
            else
            {
                number *= firstLetterPosition;
            }

            if (char.IsUpper(lastLetter))
            {
                number -= lastLetterPosition;
            }
            else
            {
                number += lastLetterPosition;
            }

            return number;
        }

        private static double ExtractNumber(string item)
        {           
            string numberPart = new string(item.Where(char.IsDigit).ToArray());

            return double.Parse(numberPart);
        }
    }
}
