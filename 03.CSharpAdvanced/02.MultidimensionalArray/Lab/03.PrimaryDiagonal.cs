using System;
using System.Linq;

namespace _3.PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];

            for (int row = 0; row < n; row++)
            {
                int[] currRow = ParceArrayFromConsole(' ');
                for (int col = 0; col < n; col++)
                {
                    matrix[row,col] = currRow[col];
                }              
            }

            int sum = 0;

            for (int row = 0; row < n; row++)
            {                
                for (int col = 0; col < n; col++)
                {
                    if (row == col)
                    {
                        sum+= matrix[row, col];                 
                    }
                }               
            }
            
            Console.WriteLine(sum);
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
