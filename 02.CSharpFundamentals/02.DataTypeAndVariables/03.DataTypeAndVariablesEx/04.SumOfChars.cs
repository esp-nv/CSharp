using System;

namespace _04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countChar=int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < countChar; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                int charToInt = (int)ch;
                sum += charToInt;
               
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
