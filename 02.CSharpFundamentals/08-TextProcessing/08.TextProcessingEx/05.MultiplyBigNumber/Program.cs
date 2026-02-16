using System;
using System.Numerics;

namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
           BigInteger bigInteger = BigInteger.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }
            BigInteger result = bigInteger * multiplier;
            Console.WriteLine(result);
        }
    }
}
