using System;

namespace _09_PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double sabresPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            int freeBelts = studentsCount - (studentsCount / 6);
            double sabresCount = Math.Ceiling(studentsCount * 1.1);
            
            double totalMoney = sabresPrice * sabresCount + robesPrice * studentsCount + beltsPrice * freeBelts;
           
            if (totalMoney <= amount)
            {
                Console.WriteLine($"The money is enough - it would cost {(totalMoney):f2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {Math.Abs(amount - totalMoney):f2}lv more.");
            }

        }
    }
}
