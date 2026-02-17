using System;
using System.Linq;

namespace _4.SymbolInMatrix
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < input.Length; col++)
                {
                    char c = input[col];
                    matrix[row, col] = c;
                }
            }
            char ch = char.Parse(Console.ReadLine());

            bool isFound = false;
            int foundRow = -1;
            int foundCol = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] != ch)
                    {
                        isFound = false;
                        continue;
                    }
                    else
                    {
                        isFound = true;
                        foundRow = row;
                        foundCol = col;
                        break;
                    }
                }

                if (isFound)
                {
                    break;
                }
            }

            if (foundRow != -1 && foundCol != -1)
            {
                Console.WriteLine($"({foundRow}, {foundCol})");
            }
            else
            {
                Console.WriteLine($"{ch} does not occur in the matrix");
            }
        }
    }
}