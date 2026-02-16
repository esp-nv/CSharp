using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.DragonArmy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dragons = new Dictionary<string, Dictionary<string, int[]>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                string type = input[0];
                string name = input[1];

                int damage = input[2] != "null" ? int.Parse(input[2]) : 45;
                int health = input[3] != "null" ? int.Parse(input[3]) : 250;
                int armor = input[4] != "null" ? int.Parse(input[4]) : 10;

                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new Dictionary<string, int[]>();
                }

                dragons[type][name] = new int[] { damage, health, armor };
            }

            foreach (var type in dragons)
            {
                var dragonStats = type.Value;

                double avgDamage = dragonStats.Values.Average(x => x[0]);
                double avgHealth = dragonStats.Values.Average(x => x[1]);
                double avgArmor = dragonStats.Values.Average(x => x[2]);

                Console.WriteLine($"{type.Key}::({avgDamage:F2}/{avgHealth:F2}/{avgArmor:F2})");

                foreach (var dragon in dragonStats.OrderBy(x => x.Key))
                {
                    var stats = dragon.Value;

                    Console.WriteLine($"-{dragon.Key} -> damage: {stats[0]}, health: {stats[1]}, armor: {stats[2]}");
                }
            }
        }
    }
}
