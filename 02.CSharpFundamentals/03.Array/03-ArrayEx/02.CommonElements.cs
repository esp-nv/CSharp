using System;

namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
             // Read two arrays of strings from the console
             string input = Console.ReadLine();           

            string[] firstArray = input.Split(' ');

            input = Console.ReadLine();

            string[] secondArray = input.Split(' ');

            for (int i = 0; i < secondArray.Length; i++)
            {
                for (int j = 0; j < firstArray.Length; j++)
                {
                    // Compare each element of the first array with each element of the second array
                    if (firstArray[j] == secondArray[i])
                    {
                        // If they are equal, print the common element
                        Console.Write(secondArray[i] + " ");
                    }
                }
            }
        }
    }
}
