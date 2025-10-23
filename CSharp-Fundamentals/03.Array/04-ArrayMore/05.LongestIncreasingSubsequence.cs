using System;

namespace _05.LongestIncreasingSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read and parse the input numbers
            int[] nums= Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            // Get the length of the input array
            int n = nums.Length;
            // Create a DP array to store the lengths of LIS ending at each index
            int[] len = new int[n];
            // Create an array to store the previous index in the LIS
            int[] prev = new int[n]; 

            for (int i = 0; i < n; i++)
            {
                // Initialize the length of LIS ending at each index to 1
                len[i] = 1;
                // Initialize the previous index to -1 (no previous element)
                prev[i] = -1;
            }

            // Variable to keep track of the maximum length of LIS found
            int maxLength = 1;
            // Variable to keep track of the index where the maximum LIS ends
            int endIndex = 0;

            // Iterate through the array starting from the second element
            for (int i = 1; i < n; i++)
            {
                // Check all previous elements
                for (int j = 0; j < i; j++) 
                {
                    // If current element is greater and can extend the LIS
                    if (nums[i] > nums[j] && len[i] < len[j] + 1) 
                    {
                        // Update the length of LIS ending at i
                        len[i] = len[j] + 1;
                        // Update the previous index to j
                        prev[i] = j; 
                    }
                }
                // If we found a longer LIS
                if (len[i] > maxLength) 
                {
                    // Update the maximum length
                    maxLength = len[i];
                    // Update the end index of the LIS
                    endIndex = i;
                }
            }


            // Reconstruct the longest increasing subsequence

            // Create an array to hold the LIS
            int[] lis = new int[maxLength];
            // Start from the end index of the LIS
            int currentIndex = endIndex;

            // Fill the LIS array in reverse order
            for (int i = maxLength - 1; i >= 0; i--) 
            {
                // Add the current element to the LIS
                lis[i] = nums[currentIndex];
                // Move to the previous index in the LIS
                currentIndex = prev[currentIndex];
            }

            // Print the longest increasing subsequence
            Console.WriteLine(string.Join(" ", lis)); 
        }
    }
}
