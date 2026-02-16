using System;

namespace _04.FoldAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read and parse the input numbers
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            // Calculate k based on the length of the input array
            int k = numbers.Length / 4; 

            // Split the array into two parts: left and right
            int[] leftPart = new int[k];
            int[] rightPart = new int[k];

            // Copy the first k elements to leftPart
            Array.Copy(numbers, 0, leftPart, 0, k);

            // Copy the last k elements to rightPart
            Array.Copy(numbers, 3 * k, rightPart, 0, k); 

            // Reverse both parts
            Array.Reverse(leftPart);
            Array.Reverse(rightPart);

            // Create the folded array by combining left and right parts
            int[] foldedArray = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                // Add corresponding elements from left part and middle part
                foldedArray[i] = leftPart[i] + numbers[k + i];

                // Add corresponding elements from right part and middle part
                foldedArray[k + i] = rightPart[i] + numbers[2 * k + i]; 
            }

            // Print the result
            Console.WriteLine(string.Join(" ", foldedArray)); 
        }
    }
}
