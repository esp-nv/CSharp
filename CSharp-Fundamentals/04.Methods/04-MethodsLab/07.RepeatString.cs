using System;

namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string result = RepeatString(input, count);
            Console.WriteLine(result);
        }
        static string RepeatString(string str, int count)
        {
            string result = string.Empty;
            for (int i = 0; i < count; i++)
            {
                result += str;
            }
            return result;
        }
    }
}
