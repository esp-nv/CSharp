using System;
using System.Linq;

namespace _11.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = Array.ConvertAll(input, int.Parse);
          
            string command = Console.ReadLine();
          
            while (command != "end")
            {
                string[] commandParts = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = commandParts[0];
              
                switch (action)
                {
                    case "exchange":
                        int index = int.Parse(commandParts[1]);
                    
                        if (index < 0 || index >= numbers.Length)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            Exchange(numbers, index);
                        }
                        break;
                    case "max":
                        PrintMax(numbers, commandParts[1]);
                        break;
                    case "min":
                        PrintMin(numbers, commandParts[1]);
                        break;
                    case "first":
                        PrintFirst(numbers, commandParts);
                        break;
                    case "last":
                        PrintLast(numbers, commandParts);
                        break;
                }
              
                command = Console.ReadLine();                    
            }
          
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        private static void PrintLast(int[] numbers, string[] commandParts)
        {
            string type = commandParts[2].ToLower();
            int count = int.Parse(commandParts[1]);
          
            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
          
            int[] result = new int[count];
            int index = 0;
          
            for (int i = numbers.Length - 1; i >= 0 && index < count; i--)
            {
                if ((type == "even" && numbers[i] % 2 == 0) || (type == "odd" && numbers[i] % 2 != 0))
                {
                    result[index++] = numbers[i];
                }
            }
          
            if (index == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Array.Reverse(result, 0, index);
              
                Console.WriteLine($"[{string.Join(", ", result.Take(index))}]");
            }
        }

        private static void PrintFirst(int[] numbers, string[] commandParts)
        {
            string type = commandParts[2].ToLower();
            int count = int.Parse(commandParts[1]);
          
            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
          
            int[] result = new int[count];
            int index = 0;
          
            for (int i = 0; i < numbers.Length && index < count; i++)
            {
                if ((type == "even" && numbers[i] % 2 == 0) || (type == "odd" && numbers[i] % 2 != 0))
                {
                    result[index++] = numbers[i];
                }
            }
          
            if (index == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", result.Take(index))}]");
            }
        }

        private static void PrintMin(int[] numbers, string v)
        {
            string type = v.ToLower();
            int minIndex = -1;
            int minValue = int.MaxValue;
          
            for (int i = 0; i < numbers.Length; i++)
            {
                if ((type == "even" && numbers[i] % 2 == 0) || (type == "odd" && numbers[i] % 2 != 0))
                {
                    if (numbers[i] < minValue)
                    {
                        minValue = numbers[i];
                        minIndex = i;
                    }
                }
            }
          
            if (minIndex == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minIndex);
            }
        }

        private static void PrintMax(int[] numbers, string v)
        {
            string type = v.ToLower();
            int maxIndex = -1;
            int maxValue = int.MinValue;
          
            for (int i = 0; i < numbers.Length; i++)
            {
                if ((type == "even" && numbers[i] % 2 == 0) || (type == "odd" && numbers[i] % 2 != 0))
                {
                    if (numbers[i] > maxValue)
                    {
                        maxValue = numbers[i];
                        maxIndex = i;
                    }
                }
            }
          
            if (maxIndex == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxIndex);
            }
        }

        private static void Exchange(int[] numbers, int index)
        {
            int[] newArray = new int[numbers.Length];
          
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i <= index)
                {
                    newArray[i] = numbers[i + numbers.Length - index - 1];
                }
                else
                {
                    newArray[i] = numbers[i - index - 1];
                }
            }
            Array.Copy(newArray, numbers, numbers.Length);
        }
    }
}
