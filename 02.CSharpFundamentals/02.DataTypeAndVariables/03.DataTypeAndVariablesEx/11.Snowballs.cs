using System;
using System.Numerics;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int count = int.Parse(Console.ReadLine()); 
          
            BigInteger maxValue = 0;
            int bestValue = 0;
            int bestTime = 0;
            int bestQuality = 0;
            for (int i = 1; i <= count; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());
                BigInteger currentSnowballValue =BigInteger.Pow ((snow/ time), quality);
                
                if (currentSnowballValue > maxValue)
                {
                    maxValue = currentSnowballValue;
                    bestValue = snow;
                    bestTime = time;
                    bestQuality = quality;
                }
            }
            Console.WriteLine($"{bestValue} : {bestTime} = {maxValue} ({bestQuality})");

        }
    }
}
