using System;
using System.Collections.Generic;
using System.Linq;

namespace _00.Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //-2.5 4 3 -2.5 -5.5 4 3 3 -2.5 3

            //чете входа
            double[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            //създажане на ново dictionary празно

            Dictionary<double, int> dic = new Dictionary<double, int>();

            //вмъква данни в dictionary
            foreach (var num in nums)
            {
                //ЗАДЪЛЖИТЕЛНО трябва да проверя дали този ключ съществува и чак след това да роботя с него иначе ше ми даде грешка
                if (!dic.ContainsKey(num))
                {
                    dic[num] = 0;
                }
                dic[num]++;
            }

            //печата dictionary
            foreach (var num in dic)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }

            // задача с вложени dictionary list

            int n = int.Parse(Console.ReadLine());

            //име на студент -> списък с оценки
            Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = names[0];
                decimal grade = decimal.Parse(names[1]);

                //ако не съдържа студента го добавя
                if (!studentGrades.ContainsKey(name))
                {
                    //това е 1 вариант
                    //studentGrades[name] = new List<double>();

                    // това е 2 вариант
                    studentGrades.Add(name, new List<decimal>());
                }

                //добавя оценката към списъка от оценки
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

            //това е съкратен вариант за печатане 
            //foreach ((string student, List<decimal> grades) in studentGrades)
            //{
            //    Console.WriteLine($"{student} -> {string.Join(" ", grades.Select(grade => grade.ToString("f2")))} (avg: {grades.Average():f2})");
            //}

            //вложеи 2 dictionary
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            string input;

            while ((input = Console.ReadLine()) != "Revision")
            {

                string[] currInput = input.Split(", ");
                string shop = currInput[0];
                string food = currInput[1];
                double price = double.Parse(currInput[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }
                if (!shops[shop].ContainsKey(food))
                {
                    shops[shop].Add(food, price);
                }
            }

            foreach (var kvp in shops)
            {
                var shop = kvp.Key;
                var food = kvp.Value;

                Console.WriteLine($"{shop}->");

                foreach (var item in food)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}


