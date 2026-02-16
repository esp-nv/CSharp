using System;

namespace _05_Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string message = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string number = Console.ReadLine();

                if (number == "0")
                {
                    message += " ";
                }
                else
                {
                    int firstDigit = int.Parse(number[0].ToString());

                    int length = number.Length;
                    int offset = (firstDigit - 2) * 3;

                    if (firstDigit == 8 || firstDigit == 9)
                    {
                        offset += 1;
                    }

                    int index = (offset + length) + 96;
                    char letter = (char)(index);
                    message += letter;
                }
            }

            Console.WriteLine(message);
        }
    }
}
