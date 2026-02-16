using System;
using System.Collections.Generic;

namespace _05.Students2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] studentInfo = input.Split(' ');

                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                int age = int.Parse(studentInfo[2]);
                string city = studentInfo[3];

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    HomeTown = city
                };

                if (IsStudentInCity(students, firstName, lastName))
                {
                    // If the student already exists, update their age and city
                    foreach (var existingStudent in students)
                    {
                        if (existingStudent.FirstName == firstName && existingStudent.LastName == lastName)
                        {
                            existingStudent.Age = age;
                            existingStudent.HomeTown = city;
                            break;
                        }
                    }

                    continue; // Skip adding a new student
                }

                students.Add(student);
            }

            string filterCity = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == filterCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

        }

        static bool IsStudentInCity(List<Student> students, string firstName, string lastname)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastname)
                {
                    return true;
                }
            }

            return false;
        }
    }

    public class Student
    {
        public string HomeTown { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        // The City property is not used in this example, but can be included if needed.
        public string City { get; set; }
    }
}
