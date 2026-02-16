using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.DrumSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
          double initialBudget = double.Parse(Console.ReadLine());

           List<int> initialDrumSet = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> currentDrumSet = new List<int>(initialDrumSet);

            string input=Console.ReadLine();

            while (input != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(input);

                for (int i = 0; i < currentDrumSet.Count; i++)
                {
                    currentDrumSet[i] -= hitPower;

                    if (currentDrumSet[i] <= 0)
                    {
                        if (initialBudget >= initialDrumSet[i] * 3)
                        {
                            initialBudget -= initialDrumSet[i] * 3;
                            currentDrumSet[i] = initialDrumSet[i];
                        }
                        else
                        {
                            currentDrumSet.RemoveAt(i);
                            initialDrumSet.RemoveAt(i);
                            i--; // Adjust index after removal
                        }
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", currentDrumSet));
            Console.WriteLine($"Gabsy has {initialBudget:f2}lv.");
        }
    }
}
