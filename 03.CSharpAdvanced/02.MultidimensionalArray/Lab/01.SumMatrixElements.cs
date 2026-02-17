using System;
using System.Linq;

namespace _1.SumMatrixElements
{
    internal class Program
    {
        static void Main()
        {
            int[] dimensions = ParceFromConsole();

            int rows = dimensions[0];
            int cols = dimensions[1];
            
            int sum = 0;

            int[,] matrix = new int[rows,cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currRow = ParceFromConsole();
                for (int col = 0; col<cols; col++)
                {
                    matrix[row,col] = currRow[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum+=matrix[row, col];
                }                
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);           
        }
        
        static int[] ParceFromConsole()
        {
            return Console.ReadLine()
                .Split(',', ' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
