using System;

namespace _11_MultiplicationTable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            if (m > 10)
            {
                Console.WriteLine($"{n} X {m} = {n * m}");
            }
            else if (m <= 10) 
            {

                for (int i = m; i <= 10; i++)
                {
                    Console.WriteLine($"{n} X {i} = {n * i}");
                }
            }
        }
    }
}
