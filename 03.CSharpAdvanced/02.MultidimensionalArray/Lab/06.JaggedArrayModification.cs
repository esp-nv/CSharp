using System;
using System.Linq;

namespace _06.JaggedArrayModification
{
    internal class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jagged = new int[rows][];

            for (int row = 0; row < jagged.Length; row++)
            {
                int[] currArray = Console.ReadLine()
                    .Split(' ').Select(int.Parse).ToArray();

                jagged[row] = new int[currArray.Length];

                for (int col = 0; col < currArray.Length; col++)
                {
                    jagged[row][col] = currArray[col];
                }
            }

            while (true)
            {
                string input = Console.ReadLine().ToLower();

                if (input == "end")
                {
                    break;
                }

                string[] cmdParts = input.Split(' ');
                string cmd = cmdParts[0];
                int row = int.Parse(cmdParts[1]);
                int col = int.Parse(cmdParts[2]);
                int value = int.Parse(cmdParts[3]);

                if (row < 0 || row >= jagged.Length ||
                    col < 0 || col >= jagged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (cmd == "add")
                {
                    jagged[row][col] += value;
                }
                else if (cmd == "subtract")
                {
                    jagged[row][col] -= value;
                }
            }

            for (int row = 0; row < jagged.Length; row++)
            {
                Console.WriteLine(string.Join(" ", jagged[row]));
            }
        }
    }
}
