using System;
using System.Collections.Generic;

namespace Lab06.RecordUniqueNames
{
    internal class Program
    {
        static void Main()
        {
            var names = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                names.Add(name);
            }

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
