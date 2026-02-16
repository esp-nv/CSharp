using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = tokens[0];
                string studentName = tokens[1];
                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>();
                }
                courses[courseName].Add(studentName);
                input = Console.ReadLine();
            }
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
