using System;
using System.Linq;

namespace DemosJaggedArray
{
    internal class Program
    {
        static void Main()
        {

            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];
            /*
             
input
3
1 2 3
4 5 6 7
8 9 10
Add 0 0 5
Subtract 1 2 2
Subtract 1 4 7 
END

output
Invalid coordinates  //Subtract 1 4 7 
6 2 3
4 5 4 7
8 9 10
              */

            //read 
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
            Console.WriteLine();

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

                //proverka na validen index po red i colona
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

            //print var1
            for (int row = 0; row < jagged.Length; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write(jagged[row][col] + " ");
                }
                Console.WriteLine();
            }

            //print - variant 2
            foreach (int[] row in jagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
