using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
          
            Dictionary<string, List<string>> companyUsers = new Dictionary<string, List<string>>();
          
            while (input != "End")
            {
                string[] tokens = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
              
                string companyName = tokens[0];
                string employeeId = tokens[1];
              
                if (!companyUsers.ContainsKey(companyName))
                {
                    companyUsers[companyName] = new List<string>();
                }
              
                if (!companyUsers[companyName].Contains(employeeId))
                {
                    companyUsers[companyName].Add(employeeId);
                }
                input = Console.ReadLine();
            }
          
            foreach (var company in companyUsers)
            {
                Console.WriteLine(company.Key);
              
                foreach (var employeeId in company.Value)
                {
                    Console.WriteLine($"-- {employeeId}");
                }
            }
        }
    }
}
