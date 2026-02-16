using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.ExtractPersonInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<StringBuilder, StringBuilder> personInformation = new Dictionary<StringBuilder, StringBuilder>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                StringBuilder name = new StringBuilder();
                StringBuilder age = new StringBuilder();

                int startIndexName = input.IndexOf('@');
                int endIndexName = input.IndexOf('|', startIndexName);
                int startIndexAge = input.IndexOf('#');
                int endIndexAge = input.IndexOf('*', startIndexAge);

                for (int j = startIndexName + 1; j < endIndexName; j++)
                {
                    name.Append(input[j]);
                }

                for (int j = startIndexAge + 1; j < endIndexAge; j++)
                {
                    age.Append(input[j]);
                }

                personInformation[name] = age;
            }

            foreach (var person in personInformation)
            {
                Console.WriteLine($"{person.Key} is {person.Value} years old.");
            }
        }
    }
}
