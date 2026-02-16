using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    internal class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public string Id { get; set; }
            public int Age { get; set; }

            public Person(string name, string id, int age)
            {
                Name = name;
                Id = id;
                Age = age;
            }
        }

        static void Main(string[] args)
        {
            string input;

            List<Person> people = new List<Person>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] personParts = input.Split(" ");
                string name = personParts[0];
                string id = personParts[1];
                int age = int.Parse(personParts[2]);

                Person person = new Person(name, id, age);
                people.Add(person);
            }

            var sortedPeople = people.OrderBy(p => p.Age).ToList();

            foreach (var person in sortedPeople)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
}
