using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> dwarfs = new Dictionary<string, Dictionary<string, int>>();

            string input;

            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                var tokens = input.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                string hatColor = tokens[1];
                int physics = int.Parse(tokens[2]);

                if (!dwarfs.ContainsKey(hatColor))
                {
                    dwarfs[hatColor] = new Dictionary<string, int>();
                }

                if (!dwarfs[hatColor].ContainsKey(name) || dwarfs[hatColor][name] < physics)
                {
                    dwarfs[hatColor][name] = physics;
                }
            }

            var sortedDwarfs = dwarfs
                .SelectMany(kvp => kvp.Value.Select(dwarf => new { Name = dwarf.Key, HatColor = kvp.Key, Physics = dwarf.Value }))
                .OrderByDescending(d => d.Physics)
                .ThenByDescending(d => dwarfs[d.HatColor].Count)
                .ToList();

            foreach (var dwarf in sortedDwarfs)
            {
                Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");
            }

        }
    }
}
