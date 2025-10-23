using System;
using System.Linq;

namespace _10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldLenght = int.Parse(Console.ReadLine());

            int[] bubPlaces = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] field = new int[fieldLenght];

            for (int i = 0; i < bubPlaces.Length; i++)
            {
                // Check if the index is valid and within the field length
                // and place a ladybug at that index if it is valid
                int bubIndex = bubPlaces[i];

                if (bubIndex >= 0 && bubIndex < fieldLenght)
                {
                    // Place a ladybug at the specified index
                    field[bubIndex] = 1;
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split(' ');
                int bugIndex = int.Parse(arguments[0]);
                string direction = arguments[1];
                int distance = int.Parse(arguments[2]);

                if (bugIndex >= 0 && bugIndex < fieldLenght && field[bugIndex] == 1)
                {
                    // Remove the ladybug from its current position
                    field[bugIndex] = 0;
                    int landIndex;

                    switch (direction)
                    {
                        case "right":
                            landIndex = bugIndex + distance;

                            while (landIndex < fieldLenght && field[landIndex] == 1)
                            {
                                // Move right until an empty spot is found
                                landIndex += distance;
                            }

                            if (landIndex >= 0 && landIndex <= field.Length - 1)
                            {
                                // If it goes out of bounds, set to -1
                                field[landIndex] = 1;
                            }
                            break;
                        case "left":
                            landIndex = bugIndex - distance;

                            while (landIndex >= 0 && field[landIndex] == 1)
                            {
                                // Move left until an empty spot is found
                                landIndex -= distance;
                            }

                            if (landIndex >= 0 && landIndex <= field.Length - 1)
                            {
                                // If it goes out of bounds, set to -1
                                field[landIndex] = 1;
                            }
                            break;
                    }
                }
            }

            // Print the final state of the field
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
