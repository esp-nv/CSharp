using System;

namespace _01.EncryptSortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Number of strings to read
            int n = int.Parse(Console.ReadLine());

            // Use an array instead of a List
            int[] encryptedValues = new int[n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int stringLength = input.Length;

                int sum = 0;

                foreach (char ch in input)
                {
                    char v = char.ToLower(ch);

                    if (v == 'a' || v == 'e' || v == 'i' || v == 'o' || v == 'u')
                    {
                        sum += ch * stringLength;
                    }
                    else
                    {
                        sum += ch / stringLength;
                    }
                }

                encryptedValues[i] = sum;
            }

            // Sort the array in ascending order
            Array.Sort(encryptedValues);

            foreach (int value in encryptedValues)
            {
                Console.WriteLine(value);
            }
        }
    }
}
