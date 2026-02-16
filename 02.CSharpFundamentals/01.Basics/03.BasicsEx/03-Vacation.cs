using System;

namespace _03_Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();

            double pay = 0.0;

            //output
            switch (day)
            {
                case "Friday":
                    switch (typeOfGroup)
                    {
                        case "Students": pay = 8.45; break;
                        case "Business": pay = 10.90; break;
                        case "Regular": pay = 15.00; break;
                    }
                    break;
                case "Saturday":
                    switch (typeOfGroup)
                    {
                        case "Students": pay = 9.80; break;
                        case "Business": pay = 15.60; break;
                        case "Regular": pay = 20.00; break;
                    }
                    break;
                case "Sunday":
                    switch (typeOfGroup)
                    {
                        case "Students": pay = 10.46; break;
                        case "Business": pay = 16.00; break;
                        case "Regular": pay = 22.50; break;
                    }
                    break;
            }

            if (typeOfGroup == "Students")
            {
                if (countOfPeople >= 30)
                {
                    double bill = countOfPeople * pay;
                    double totalBill = bill - (bill * 0.15);
                    Console.WriteLine($"Total price: {totalBill:f2}");
                }
                else
                {
                    double totalBill = countOfPeople * pay;
                    Console.WriteLine($"Total price: {totalBill:f2}");
                }
            }

            if (typeOfGroup == "Business")
            {

                if (countOfPeople >= 100)
                {
                    double totalBill = (countOfPeople - 10) * pay;
                    Console.WriteLine($"Total price: {totalBill:f2}");
                }
                else
                {
                    double totalBill = countOfPeople * pay;
                    Console.WriteLine($"Total price: {totalBill:f2}");
                }
            }

            if (typeOfGroup == "Regular")
            {
                if (countOfPeople >= 10 && countOfPeople <= 20)
                {
                    double bill = countOfPeople * pay;
                    double totalBill = bill - (bill * 0.05);
                    Console.WriteLine($"Total price: {totalBill:f2}");
                }
                else
                {
                    double totalBill = countOfPeople * pay;

                    Console.WriteLine($"Total price: {totalBill:f2}");
                }

            }

        }
    }
}
