using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] currRow = Console.ReadLine()
                         .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                         .Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            int sumFirstDiagonal = 0;
            int sumSecondDiagonal = 0;

            for (int row = 0, col = n - 1; row < n; row++, col--)
            {
                sumFirstDiagonal += matrix[row, row];
                sumSecondDiagonal += matrix[row, col];
            }

            Console.WriteLine(Math.Abs(sumFirstDiagonal - sumSecondDiagonal));
        }
    }
}
