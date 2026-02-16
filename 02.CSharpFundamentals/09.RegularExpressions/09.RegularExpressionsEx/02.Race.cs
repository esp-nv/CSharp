using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вход: списък с участници, разделени със запетая и интервал
            string[] participants = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            // Речник за съхранение на резултати
            Dictionary<string, int> racers = new Dictionary<string, int>();

            string input;

            // Регекс за извличане на букви и цифри
            Regex nameRegex = new Regex(@"[A-Za-z]");
            Regex digitRegex = new Regex(@"\d");

            while ((input = Console.ReadLine()) != "end of race")
            {
                // Вадим всички букви и съставяме име
                string name = string.Concat(nameRegex.Matches(input).Select(m => m.Value));

                // Вадим всички цифри и изчисляваме сума
                int distance = digitRegex.Matches(input).Select(m => int.Parse(m.Value)).Sum();

                // Ако името е в списъка на участниците, добавяме/актуализираме дистанцията
                if (participants.Contains(name))
                {
                    if (!racers.ContainsKey(name))
                    {
                        racers[name] = 0;
                    }
                    racers[name] += distance;
                }
            }

            // Подреждаме участниците по изминато разстояние (низходящо)
            var top3 = racers.OrderByDescending(r => r.Value).Take(3).ToList();

            // Отпечатваме резултатите
            Console.WriteLine("1st place: " + top3[0].Key);
            Console.WriteLine("2nd place: " + top3[1].Key);
            Console.WriteLine("3rd place: " + top3[2].Key);
        }
    }
}
