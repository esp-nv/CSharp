using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string command = Console.ReadLine();

            while (command != "3:1")
            {
                string[] commandParts = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string action = commandParts[0];
                int index1 = int.Parse(commandParts[1]);
                int index2 = int.Parse(commandParts[2]);

                if (action == "merge")
                {

                    
                    index1 = Math.Clamp(index1,0, input.Count-1);
                    index2 = Math.Clamp(index2, 0, input.Count - 1);

                    List<string> mergedElements = input.GetRange(index1,index2-index1+1);

                    input.RemoveRange(index1, index2-index1+1);

                    string mergedString = string.Join("", mergedElements);

                    input.Insert(index1, mergedString);                    
                }
                else if (action == "divide")
                {
                    if (index1 < 0 || index1 >= input.Count || index2 <= 0) continue;
                    string elementToDivide = input[index1];
                    int partLength = elementToDivide.Length / index2;

                    List<string> dividedParts = new List<string>();

                    for (int i = 0; i < index2; i++)
                    {
                        int startIndex = i * partLength;
                        int length = (i == index2 - 1) ? elementToDivide.Length - startIndex : partLength;
                        dividedParts.Add(elementToDivide.Substring(startIndex, length));
                    }

                    input.RemoveAt(index1);
                    input.InsertRange(index1, dividedParts);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
