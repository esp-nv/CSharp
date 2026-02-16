using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<string> validUsernames = new List<string>();

            for (int i = 0; i < usernames.Length; i++)
            {
                string username = usernames[i];

                if (username.Length >= 3 && username.Length <= 16 &&
                    username.All(c => char.IsLetterOrDigit(c) || c == '-' || c == '_'))
                {
                    validUsernames.Add(username);
                }
            }

            foreach (string username in validUsernames)
            {
                Console.WriteLine(username);

            }
        }
    }
}
