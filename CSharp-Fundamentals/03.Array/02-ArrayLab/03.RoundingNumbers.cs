using System;

namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);

            double[] roundedNumbers = new double[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                roundedNumbers[i] = Math.Round(numbers[i], MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < roundedNumbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {(int)roundedNumbers[i]}");
            }
        }
    }
}
