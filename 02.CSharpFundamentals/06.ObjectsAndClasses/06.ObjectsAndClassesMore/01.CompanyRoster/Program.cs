using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CompanyRoster
{

    internal class Program
    {
        public class Employee
        {
            public string Name { get; set; }
            public decimal Salary { get; set; }
            public string Department { get; set; }
            public Employee(string name, decimal salary, string department)
            {
                Name = name;
                Salary = salary;
                Department = department;
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = parts[0];
                decimal salary = decimal.Parse(parts[1]);
                string department = parts[2];

                employees.Add(new Employee(name, salary, department));
            }


            var topDepartment = employees
                 .GroupBy(e => e.Department)
                 .Select(g => new
                 {
                     Department = g.Key,
                     AverageSalary = g.Average(e => e.Salary)
                 })
                 .OrderByDescending(d => d.AverageSalary)
                 .First();
            if (topDepartment != null)
            {
                Console.WriteLine($"Highest Average Salary: {topDepartment.Department}");
                var topEmployees = employees
                    .Where(e => e.Department == topDepartment.Department)
                    .OrderByDescending(e => e.Salary);
                foreach (var emp in topEmployees)
                {
                    Console.WriteLine($"{emp.Name} {emp.Salary:F2}");
                }
            }
        }

    }
}

