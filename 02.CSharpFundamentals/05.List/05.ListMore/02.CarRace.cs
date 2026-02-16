using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
         
           double finishLine = numbers.Count / 2;
            double leftTime = 0;
            double rightTime = 0;

            for (int i = 0; i < finishLine; i++)
            {
                if (numbers[i] == 0)
                {
                    leftTime -= leftTime* 0.2;
                }
                else
                {
                    leftTime += numbers[i];
                }
            }

            for (int i = numbers.Count - 1; i > finishLine; i--)
            {
                if (numbers[i] == 0)
                {
                    rightTime -= rightTime* 0.2;
                }
                else
                {
                    rightTime += numbers[i];
                }
            }

            if (leftTime < rightTime)
            {
                Console.WriteLine($"The winner is left with total time: {leftTime}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightTime}");
            }
        }
    }
}
