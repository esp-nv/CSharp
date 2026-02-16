using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!students.ContainsKey(studentName))
                {
                    students[studentName] = new List<double>();
                }
                students[studentName].Add(grade);
            }
            foreach (var student in students)
            {
                double averageGrade = student.Value.Average();
                if (averageGrade >= 4.5)
                {
                    Console.WriteLine($"{student.Key} -> {averageGrade:F2}");
                }
            }
        }
    }
}
