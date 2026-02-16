using System;

namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(GetMiddleCharacter(input));
        }

        private static string GetMiddleCharacter(string input)
        {
            int length = input.Length;
            string result = string.Empty;

            if (length % 2 == 0)
            {
                result = input[length / 2 - 1].ToString() + input[length / 2 ].ToString();
            }
            else
            {
                result = input[length / 2].ToString();   
            }
          
            return result;
        }
    }
}
