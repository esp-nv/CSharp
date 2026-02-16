using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _00.LongestPalindromeSub_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string longestPalindrome = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i; j < input.Length; j++)
                {
                    string substring = input.Substring(i, j - i + 1);

                    if (IsPalidromme(substring) && substring.Length > longestPalindrome.Length)
                    {
                        longestPalindrome = substring;
                    }
                }
            }
         
            Console.WriteLine(longestPalindrome.Length);
        }

        private static bool IsPalidromme(string substring)
        {
            bool IsPalindrome(string str)
            {
                int left = 0;
                int right = str.Length - 1;

                while (left < right)
                {
                    if (str[left] != str[right])
                    {
                        return false;
                    }
                    left++;
                    right--;
                }

                return true;
            }

            return IsPalindrome(substring);
        }
    }
}
