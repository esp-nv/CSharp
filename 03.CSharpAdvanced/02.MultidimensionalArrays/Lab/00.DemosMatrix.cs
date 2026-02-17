using System;
using System.Linq;

namespace 00.Demos
{
    internal class Program
    {
        static void Main()
        {
            int[] dimensions = ParceArrayFromConsole(' ', ',');
            int rows = dimensions[0];
            int cols = dimensions[1];

            int sum = 0;
            int[,] matrix = new int[rows, cols];

            //попълване на матрица
            int[,] m = ReadMatrix(rows, cols);

            //сумира числата в матрицата  
            //вариант 1:
            foreach (var item in m)
            {
                sum += item;
            }

            //вариант 2:
            int sum1 = SumMatrix(m);

            Console.WriteLine($"Брой редове: {rows}");
            Console.WriteLine($"Брой колони: {cols}");
            Console.WriteLine($"Обща сума на числата в матрицата: {sum}");
            Console.WriteLine($"Обща сума на числата в матрицата: {sum1}");
            Console.WriteLine($"Принтиране на матрицата");

            //принтиране на матрицата
            PrintMatrix(m);
        }

        private static int SumMatrix(int[,] matrix)
        {
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                }

            }

            return sum;
        }

        private static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] currRow = ParceArrayFromConsole(' ');
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currRow[col]; // чете матрица

                }
            }
            return matrix;
        }

        private static void PrintMatrix(int[,] matrix)
        {

            // int[,] matrix = new int [rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[] ParceArrayFromConsole(params char[] splitSymbols)
        {
            return Console.ReadLine()
                  .Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();

        }

    }
}

