using System;

namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int capacityWithFullCourses = (int)Math.Ceiling((double)persons / capacity);
            
            Console.WriteLine(capacityWithFullCourses);
        }
    }
}
