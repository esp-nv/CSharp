using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab02.AverageStudentGrades
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string,List<decimal>> studentGrades = new Dictionary<string,List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] names = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = names[0];
                decimal grade = decimal.Parse(names[1]);

                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades.Add(name,new List<decimal>());
                }

                studentGrades[name].Add(grade);
            }

            foreach (var pair in studentGrades)
            {
                var name = pair.Key;
                var studentsGrade = pair.Value;
                var avgGrades = studentsGrade.Average();

                Console.Write($"{name} -> ");

                foreach (var grade in studentsGrade)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {avgGrades:f2})");
            }

            //short code print
            //foreach ((string student, List<decimal> grades) in studentGrades)
            //{
            //    Console.WriteLine($"{student} -> {string.Join(" ", grades.Select(grade => grade.ToString("f2")))} (avg: {grades.Average():f2})");
            //}
        }
    }
}
