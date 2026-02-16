using System;

namespace _11.RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // double length, width, heigth = 0;
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double heigth = double.Parse(Console.ReadLine());

            double volume = length * width * heigth * 1 / 3;

            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}
