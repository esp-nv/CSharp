using System;
namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            short poursCount = short.Parse(Console.ReadLine());
           
            short poursSum = 0;
            byte waterTankCapacity = byte.MaxValue;

            for (int i = 1; i <= poursCount; i++)
            {
                short currentPour = short.Parse(Console.ReadLine());

                poursSum += currentPour;

                if (poursSum > waterTankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");

                    poursSum -= currentPour;
                }
            }

            Console.WriteLine(poursSum);
        }
    }
}
