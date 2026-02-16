using System;

namespace _10.LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());

            if ((int)ch > 64 && (int)ch < 91)
            {
                Console.WriteLine("upper-case");
            }

            if ((int)ch > 96 && (int)ch < 123)
            {
                Console.WriteLine("lower-case");
            }           
        }
    }
}
