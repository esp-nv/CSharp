using System;

namespace _05_Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string pass = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                char currChar = username[i];
                pass += currChar;

            }

            int counter = 1;

            while (counter < 5)
            {
                string inputPass = Console.ReadLine();

                if (inputPass == pass)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    if (counter == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }

                    if (counter < 4)
                    {

                        Console.WriteLine("Incorrect password. Try again."); counter++;
                    }
                }
            }
        }
    }
}
