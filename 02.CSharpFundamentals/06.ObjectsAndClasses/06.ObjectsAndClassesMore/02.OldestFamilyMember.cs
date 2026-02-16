using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OldestFamilyMember
{
    internal class Program
    {
        public class FamilyMember
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public FamilyMember(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<FamilyMember> familyMembers = new List<FamilyMember>();

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = parts[0];
                int age = int.Parse(parts[1]);
                familyMembers.Add(new FamilyMember(name, age));
            }

            var oldestMember = familyMembers.OrderByDescending(m => m.Age).FirstOrDefault();

            if (oldestMember != null)
            {
                Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
            }
        }
    }
}
