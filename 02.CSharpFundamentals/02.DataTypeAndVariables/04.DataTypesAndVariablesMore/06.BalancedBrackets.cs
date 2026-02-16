using System;

namespace _06.BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool isBalanced = true;
            bool isOpen = false;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    if (isOpen)
                    {
                        isBalanced = false;
                        break;
                    }
                    isOpen = true;
                }
                else if (input == ")")
                {
                    if (!isOpen)
                    {
                        isBalanced = false;
                        break;
                    }
                    isOpen = false;
                }
            }

            if (isOpen)
            {
                isBalanced = false;
            }

            Console.WriteLine(isBalanced ? "BALANCED" : "UNBALANCED");
        }
    }
}
