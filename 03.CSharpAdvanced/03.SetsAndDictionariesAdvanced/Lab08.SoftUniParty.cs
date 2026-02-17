using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab08.SoftUniParty
{
    internal class Program
    {
        static void Main()
        {
            HashSet<string> vipGuest = new HashSet<string>();
            HashSet<string> regularGuest = new HashSet<string>();

            bool isParty=false;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                if(input == "PARTY")
                {
                    isParty = true;
                }

                char currChar = input[0];

                if (input != "PARTY" && !isParty)
                {
                    if (input[0] > 47 && input[0] < 58)
                    {
                        vipGuest.Add(input);
                    }
                    else
                    {
                        regularGuest.Add(input);
                    }
                }

                if (isParty)
                {
                    if (vipGuest.Contains(input))
                    {
                        vipGuest.Remove(input);
                    }
                    if (regularGuest.Contains(input))
                    {
                        regularGuest.Remove(input);
                    }
                }
            }

            int totalGuest = vipGuest.Count + regularGuest.Count;

            Console.WriteLine(totalGuest);

            if (vipGuest.Count > 0)
            {
                foreach (string input in vipGuest)
                {
                    Console.WriteLine(input);
                }
            }

            if (regularGuest.Count > 0)
            {
                foreach (string input in regularGuest)
                {
                    Console.WriteLine(input);
                }
            }
        }
    }
}
