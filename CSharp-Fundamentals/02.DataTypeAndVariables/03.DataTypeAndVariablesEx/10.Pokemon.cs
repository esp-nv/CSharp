using System;
using System.Numerics;

namespace _10.Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int target = int.Parse(Console.ReadLine());
            int exhaust = int.Parse(Console.ReadLine());

            int targetCount = 0;
            int start = power;

            while (power >= target)
            {
                targetCount++;
                power -= target;

                if (power != 0 && start != 0 && exhaust != 0)
                {
                    if (power == start / 2 && exhaust != 0)
                    {
                        power /= exhaust;
                    }
                }
            }

            Console.WriteLine(power);
            Console.WriteLine(targetCount);
        }
    }
}
