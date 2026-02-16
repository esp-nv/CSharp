using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.TreasureFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string input;

            List<int> keyList = new List<int>(key);
            StringBuilder treasure = new StringBuilder();

            foreach (int i in keyList)
            {
                treasure.Append((char)i);
            }
            input = treasure.ToString();
           
            while ((input = Console.ReadLine()) != "find")
            {
                StringBuilder decryptedMessage = new StringBuilder();

                for (int i = 0; i < input.Length; i++)
                {
                    decryptedMessage.Append((char)(input[i] - keyList[i % keyList.Count]));
                }

                int startIndex = decryptedMessage.ToString().IndexOf('&') + 1;
                int endIndex = decryptedMessage.ToString().IndexOf('&', startIndex);
                string treasureType = decryptedMessage.ToString().Substring(startIndex, endIndex - startIndex);
                startIndex = decryptedMessage.ToString().IndexOf('<') + 1;
                endIndex = decryptedMessage.ToString().IndexOf('>', startIndex);
                string coordinates = decryptedMessage.ToString().Substring(startIndex, endIndex - startIndex);

                Console.WriteLine($"Found {treasureType} at {coordinates}");
            }
        }
    }
}
