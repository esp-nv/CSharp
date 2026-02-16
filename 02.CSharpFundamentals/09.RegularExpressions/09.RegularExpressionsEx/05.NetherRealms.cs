using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.NetherRealms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вход: ред с имена на демони, разделени със запетая и евентуални интервали
            string input = Console.ReadLine();

            // Разделяме по запетая и махаме празни пространства
            string[] demonNames = input
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(name => name) // сортиране по азбучен ред
                .ToArray();

            // Регекси:
            Regex healthRegex = new Regex(@"[^0-9+\-*/.]"); // само символи, които се броят за health
            Regex numberRegex = new Regex(@"[+-]?\d+(\.\d+)?"); // числа с опционален знак и десетичност

            foreach (string demon in demonNames)
            {
                // Health: сума от ASCII кодовете на символите, които не са цифри, знаци и т.н.
                int health = healthRegex.Matches(demon)
                    .Sum(m => (int)m.Value[0]);

                // Damage: сума от всички намерени числа
                double damage = numberRegex.Matches(demon)
                    .Select(m => double.Parse(m.Value))
                .Sum();

                // Модификатори: *, /
                foreach (char c in demon)
                {
                    if (c == '*') damage *= 2;
                    else if (c == '/') damage /= 2;
                }

                // Отпечатване с формат
                Console.WriteLine($"{demon} - {health} health, {damage:F2} damage");
            }
        }
    }
}
