using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public decimal Grade { get; set; }
            public string City { get; set; }
            public Student(string firstName, string lastName, decimal grade)
            {
                FirstName = firstName;
                LastName = lastName;
                Grade = grade;
                
            }
            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade}";
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i =1 ; i <= n; i++)
            {
                string[] studentParts = Console.ReadLine().Split(" ");
                string firstName = studentParts[0];
                string lastName = studentParts[1];
                decimal grade = decimal.Parse(studentParts[2]);
                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }

            string filterGrade = Console.ReadLine();

            var filteredStudents = students.OrderByDescending(s => s.Grade).ToList();

            Console.WriteLine(string.Join("\n", filteredStudents));
        }
    }
}
