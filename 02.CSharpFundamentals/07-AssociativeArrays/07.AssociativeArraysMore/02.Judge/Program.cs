using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Съхраняваме: контест -> (потребител -> точки)
            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();

            // Съхраняваме: потребител -> общо точки
            Dictionary<string, int> individualStats = new Dictionary<string, int>();

            string input;
            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] tokens = input.Split(" -> ");
                string username = tokens[0];
                string contest = tokens[1];
                int points = int.Parse(tokens[2]);

                // Ако контестът не съществува, го създаваме
                if (!contests.ContainsKey(contest))
                {
                    contests[contest] = new Dictionary<string, int>();
                }

                // Ако потребителят не е участвал в този контест – го добавяме
                if (!contests[contest].ContainsKey(username))
                {
                    contests[contest][username] = points;
                }
                else
                {
                    // Ако участва и новите точки са по-високи – актуализираме
                    if (contests[contest][username] < points)
                    {
                        contests[contest][username] = points;
                    }
                }
            }

            // Изчисляваме индивидуалната статистика
            foreach (var contest in contests)
            {
                foreach (var participant in contest.Value)
                {
                    string user = participant.Key;
                    int points = participant.Value;

                    if (!individualStats.ContainsKey(user))
                    {
                        individualStats[user] = 0;
                    }

                    individualStats[user] += points;
                }
            }

            //Извеждане на резултати по контест
            foreach (var contest in contests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");

                int position = 1;

                foreach (var participant in contest.Value
                             .OrderByDescending(p => p.Value)
                             .ThenBy(p => p.Key))
                {
                    Console.WriteLine($"{position}. {participant.Key} <::> {participant.Value}");
                    position++;
                }
            }

            // Извеждане на индивидуалната статистика
            Console.WriteLine("Individual standings:");

            int pos = 1;

            foreach (var user in individualStats
                         .OrderByDescending(u => u.Value)
                         .ThenBy(u => u.Key))
            {
                Console.WriteLine($"{pos}. {user.Key} -> {user.Value}");
                pos++;
            }
        }
    }
}
