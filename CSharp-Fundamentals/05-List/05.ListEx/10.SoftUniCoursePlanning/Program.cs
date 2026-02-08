using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniCoursePlanning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Четем началния график (разделени със ", ")
            List<string> schedule = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "course start")
            {
                string[] parts = input.Split(':');
                string command = parts[0];
                string lessonTitle = parts[1];

                switch (command)
                {
                    case "Add":
                        if (!schedule.Contains(lessonTitle))
                            schedule.Add(lessonTitle);
                        break;

                    case "Insert":
                        int index = int.Parse(parts[2]);
                        if (!schedule.Contains(lessonTitle) && index >= 0 && index <= schedule.Count)
                            schedule.Insert(index, lessonTitle);
                        break;

                    case "Remove":
                        schedule.Remove(lessonTitle);
                        schedule.Remove($"{lessonTitle}-Exercise");
                        break;

                    case "Swap":
                        string lesson2 = parts[2];
                        if (schedule.Contains(lessonTitle) && schedule.Contains(lesson2))
                        {
                            // Разменяме уроците
                            int index1 = schedule.IndexOf(lessonTitle);
                            int index2 = schedule.IndexOf(lesson2);
                            (schedule[index1], schedule[index2]) = (schedule[index2], schedule[index1]);

                            // Разменяме упражненията, ако има
                            string exercise1 = $"{lessonTitle}-Exercise";
                            string exercise2 = $"{lesson2}-Exercise";

                            bool hasExercise1 = schedule.Contains(exercise1);
                            bool hasExercise2 = schedule.Contains(exercise2);

                            if (hasExercise1)
                            {
                                schedule.Remove(exercise1);
                                schedule.Insert(schedule.IndexOf(lessonTitle) + 1, exercise1);
                            }

                            if (hasExercise2)
                            {
                                schedule.Remove(exercise2);
                                schedule.Insert(schedule.IndexOf(lesson2) + 1, exercise2);
                            }
                        }
                        break;

                    case "Exercise":
                        string exercise = $"{lessonTitle}-Exercise";
                        if (schedule.Contains(lessonTitle))
                        {
                            if (!schedule.Contains(exercise))
                            {
                                int lessonIndex = schedule.IndexOf(lessonTitle);
                                schedule.Insert(lessonIndex + 1, exercise);
                            }
                        }
                        else
                        {
                            schedule.Add(lessonTitle);
                            schedule.Add(exercise);
                        }
                        break;
                }
            }

            // Извеждаме финалния списък
            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }
    }
}
