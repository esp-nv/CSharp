using System;
using System.Collections.Generic;

namespace _06.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>(Console.ReadLine().Split(", "));
            string input = Console.ReadLine();

            while (queue.Count > 0)
            {
                var cmd = input.Split() [0];

                switch (cmd)
                {
                    case "Play":
                        queue.Dequeue();
                        break;
                    case "Add":
                        string songName = input.Substring(input.IndexOf(" ") + 1);
                        if (queue.Contains(songName))
                        {
                            Console.WriteLine($"{songName} is already contained!");
                        }
                        else
                        {
                            queue.Enqueue(songName);
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", queue));
                        break;
                }
                
                input = Console.ReadLine();
            }

            Console.WriteLine("No more songs!");
        }
    }
}
