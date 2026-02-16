using System;

namespace _02.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the number of rows for Pascal's Triangle
            int n = int.Parse(Console.ReadLine());

            // Create a jagged array to hold the triangle
            long[][] triangle = new long[n][];
            
            for (int i = 0; i < n; i++)
            {
                // Initialize each row with the appropriate size
                triangle[i] = new long[i + 1];

                // The first element of each row is always 1
                triangle[i][0] = 1;

                // The last element of each row is also always 1
                triangle[i][i] = 1; 

                // Fill in the values for the current row
                for (int j = 1; j < i; j++)
                {
                    triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                }
            }

            // Print the triangle
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    // Print each value in the row
                    Console.Write(triangle[i][j] + " ");
                }

                // Move to the next line after printing a row
                Console.WriteLine(); 
            }
        }
    }
}
