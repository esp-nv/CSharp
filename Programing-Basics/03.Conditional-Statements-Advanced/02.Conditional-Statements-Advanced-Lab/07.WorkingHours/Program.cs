﻿// 07. Working Hours

//input
int hour = int.Parse(Console.ReadLine());
string day = Console.ReadLine();

//output
switch (day)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":    
    case "Saturday":
        if (hour >= 10 && hour <= 18)
        {
            Console.WriteLine("open");
        }
        else
        {
            Console.WriteLine("closed");
        }

            break;
    case "Sunday":

        Console.WriteLine("closed"); break;
    
}