using System;
using System.Linq;

namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (!IsValidLenght(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!IsOnlyLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!IsAtLeastTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (IsValidLenght(password) && IsOnlyLettersAndDigits(password) && IsAtLeastTwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool IsAtLeastTwoDigits(string password)
        {

            int digitCount = password.Count(char.IsDigit);
            if (digitCount < 2)
            {
                return false;
            }
            return true;
        }

        static bool IsValidLenght(string input)
        {

            if (input.Length < 6 || input.Length > 10)
            {

                return false;
            }
            return true;
        }

        static bool IsOnlyLettersAndDigits(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }

            }
            return true;
        }
    }
}
