using System;

namespace _02.CenterPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            PrintCloserToCenter(x1, y1, x2, y2);
            // The method PrintCloserToCenter should determine which point is closer to the center (0, 0)
        }

        static double PrintCloserToCenter(double x1, double y1, double x2, double y2)
        {
            double distance1 = Math.Abs(x1) + Math.Abs(y1);
            double distance2 = Math.Abs(x2)+ Math.Abs(y2);
            if (distance1 < distance2)
            {
                Console.WriteLine($"({x1}, {y1})");
                return distance1;
            }
            else if (distance2 < distance1)
            {
                Console.WriteLine($"({x2}, {y2})");
                return distance2;
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
                return distance1;
            }
        }
    }
}
