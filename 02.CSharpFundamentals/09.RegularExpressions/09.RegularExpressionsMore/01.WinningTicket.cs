using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01.WinningTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine()
                 .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"([@#$^])\1{5,9}"; // намира символ повторен от 6 до 10 пъти

            foreach (string ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                string leftHalf = ticket.Substring(0, 10);
                string rightHalf = ticket.Substring(10);

                Match leftMatch = Regex.Match(leftHalf, pattern);
                Match rightMatch = Regex.Match(rightHalf, pattern);

                if (leftMatch.Success && rightMatch.Success)
                {
                    string leftSymbol = leftMatch.Value[0].ToString();
                    string rightSymbol = rightMatch.Value[0].ToString();

                    if (leftSymbol == rightSymbol)
                    {
                        int matchLength = Math.Min(leftMatch.Value.Length, rightMatch.Value.Length);

                        if (matchLength == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {matchLength}{leftSymbol} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {matchLength}{leftSymbol}");
                        }

                        continue;
                    }
                }

                Console.WriteLine($"ticket \"{ticket}\" - no match");
            }
        }
    }    
}
