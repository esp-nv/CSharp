using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            // Remove negative numbers
            int count = numbers.Count;
            for (int i = 0; i < count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                    i--; // Adjust index after removal
                    count--; // Decrease count since we removed an element
                }
            }
            // Reverse the list
            numbers.Reverse();
            // Check if the list is empty
            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                // Print the reversed list
                Console.WriteLine(string.Join(" ", numbers));

            }
        }
    }
}
