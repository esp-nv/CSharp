using System;
using System.Linq;

namespace _05.SquareWithMaxiSum
{
    internal class Program
    {
        static void Main()
        {
            int[] inputArrray = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = inputArrray[0];
            int cols = inputArrray[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] number = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = number[col];
                }
            }

            int sum = int.MinValue;
            int rowIndex = -1;
            int colIndex = -1;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    int sumFirstRow = matrix[row, col] + matrix[row, col + 1];
                    int sumSecondRow = matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (sumFirstRow + sumSecondRow > sum)
                    {
                        sum = sumFirstRow + sumSecondRow;
                        rowIndex = row;
                        colIndex = col;
                    }
                }
            }

            //Console.WriteLine(rowIndex+" " + colIndex);
            for (int row = rowIndex; row <= rowIndex + 1; row++)
            {
                for (int col = colIndex; col <= colIndex + 1; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(sum);
        }
    }
}
