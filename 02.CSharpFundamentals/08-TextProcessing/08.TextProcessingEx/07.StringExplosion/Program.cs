using System;

namespace _07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            int explosionPower = 0;
            string result = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (currentChar == '>')
                {
                    explosionPower += int.Parse(input[i + 1].ToString());
                    result += currentChar;
                }
                else if (explosionPower > 0)
                {
                    explosionPower--;
                    continue; // Skip adding the character to the result
                }
                else
                {
                    result += currentChar;
                }
            }
            Console.WriteLine(result);
        }
    }
}
