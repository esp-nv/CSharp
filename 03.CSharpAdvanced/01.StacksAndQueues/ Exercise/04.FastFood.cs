using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    internal class Program
    {
        static void Main()
        {
            int qty = int.Parse(Console.ReadLine());
            var queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
          
            int maxOrder = queue.Max();
            Console.WriteLine(maxOrder);
        
            while (queue.Count > 0)
            {
                if (qty >= queue.Peek())
                {
                    qty-=queue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (queue.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
