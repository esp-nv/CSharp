using System;

namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                char[] reversed = input.ToCharArray();
                Array.Reverse(reversed);
                Console.WriteLine($"{input} = {new string(reversed)}");
                input = Console.ReadLine();
            }

        }
    }
}
