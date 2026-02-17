using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> kids = new Queue<string>(Console.ReadLine().Split());

            int count = int.Parse(Console.ReadLine());
     
            while (kids.Count > 1)
            {
                string lastKids = string.Empty;

                for (int i = 1; i <= count; i++) 
                {
                    lastKids=kids.Dequeue();

                    if (i!=count)
                    {
                        kids.Enqueue(lastKids);
                    }
                }

                Console.WriteLine($"Removed {lastKids}");                
            }

            Console.WriteLine($"Last is {kids.Dequeue()}");
        }
    }
}
