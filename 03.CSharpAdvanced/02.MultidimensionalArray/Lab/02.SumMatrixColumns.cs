using System;
using System.Linq;

namespace _2.SumMatrixColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = ParseArrayFromConsole(',', ' ');

            int rows = dimensions[0];
            int cols = dimensions[1];           

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currRow = ParseArrayFromConsole(' ');
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }
                
                Console.WriteLine(sum);
            }
        }
        
        static int[] ParseArrayFromConsole(params char[] splitSymbols)
        {
             return Console.ReadLine()
                    .Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
        }
    }
}
