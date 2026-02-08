using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string messages = Console.ReadLine();
            List<int> messageIndices = new List<int>();
            string result = string.Empty;

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = 0;
                string currentNumberStr = numbers[i].ToString();
                for (int j = 0; j < currentNumberStr.Length; j++)
                {
                    currentNumber += int.Parse(currentNumberStr[j].ToString());
                }
                messageIndices.Add(currentNumber);
            }
            for (int i = 0; i < messageIndices.Count; i++)
            {
                if (messageIndices[i] >= messages.Length)
                {
                    messageIndices[i] = messageIndices[i] % messages.Length;
                }
            }
            for (int i = 0; i < messageIndices.Count; i++)
            {
                result += messages[messageIndices[i]];
                messages = messages.Remove(messageIndices[i], 1);
            }
            Console.WriteLine(result);

      //      Console.WriteLine(string.Join(" ", messageIndices));
        }
    }
}
