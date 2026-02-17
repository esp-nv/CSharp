using System;
using System.Linq;

namespace _07.PascalTriangle
{
    internal class Program
    {
        static void Main()
        {
            long rows = int.Parse(Console.ReadLine());

            long[][] pascalTriangle = new long[rows][];

            //fills the first row with 1
            if (rows >= 1)
            {
                pascalTriangle[0] = new long[] { 1 };
            }

            if (rows >= 2)
            {
                pascalTriangle[1] = new long[] { 1, 1 };
            }

            for (int row = 2; row < rows; row++)
            {

                // to insert a value -I need to create it
                pascalTriangle[row] = new long[row + 1];
                pascalTriangle[row][0] = 1;

                for (long col = 1; col < row; col++)
                {
                    pascalTriangle[row][col] =
                        pascalTriangle[row - 1][col] +
                        pascalTriangle[row - 1][col - 1];
                }

                pascalTriangle[row][row] = 1;
            }

            //int lastRowLen = string.Join(" ", pascalTriangle[rows - 1]).Length;
            //foreach (var currRow in pascalTriangle)
            //{
            //     string currRowText = string.Join(" ", currRow);
            //    int diff = lastRowLen - currRowText.Length;
            //    int halfDiff = diff / 2;
            //    string whiteSpace = new string(' ', halfDiff);
            //    Console.WriteLine($"{whiteSpace}{currRowText}");
            //}

            foreach (var currentRow in pascalTriangle)
            {
                Console.WriteLine(string.Join(" ", currentRow));
            }
        }
    }
}
