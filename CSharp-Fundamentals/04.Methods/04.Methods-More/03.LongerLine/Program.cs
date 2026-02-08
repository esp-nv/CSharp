using System;

namespace _03.LongerLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double a1 = double.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine());
            double a2 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double firstLineLength = CalculateLineLength(x1, y1, x2, y2);
            double secondLineLength = CalculateLineLength(a1, b1, a2, b2);
            // Console.WriteLine();
            if (firstLineLength >= secondLineLength)
            {
                PrintLongerLine(x1, y1,x2,y2);
            }
            else
            {
                PrintLongerLine(a1, b1, a2, b2);
            }



        }

        private static void PrintLongerLine(double x1, double y1, double x2, double y2)
        {
           double firstDistance = Math.Abs(x1) + Math.Abs(y1);
           double secondDistance = Math.Abs(x2) + Math.Abs(y2);
                if (firstDistance <= secondDistance)
                {
                 Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                 Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }

        private static double CalculateLineLength(double x1, double y1, double x2, double y2)
        {
            return Math.Abs(x1)+Math.Abs(y1) + Math.Abs(x2)+Math.Abs(y2);

        }
    }
}
