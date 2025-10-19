//12.Trade Commissions
//input
string day = Console.ReadLine();
double profit = double.Parse(Console.ReadLine());

//output
switch (day)
{
    case "Sofia":
        if (profit <0)
        {
            Console.WriteLine("error");
        }
       else if ( profit >= 0 && profit <=500)
        {
            Console.WriteLine($"{(profit*5/100):f2}");
        }
        else if ( profit >500 && profit <= 1000)
        {
            Console.WriteLine($"{(profit * 7 / 100):f2}");
        }
        else if ( profit > 1000 && profit <= 10000)
        {
            Console.WriteLine($"{(profit * 8 / 100):f2}");
        }
        else if ( profit > 10000)
        {
            Console.WriteLine($"{(profit * 12 / 100):f2}");
        }
        break;
    case "Varna":
        if (profit < 0)
        {
            Console.WriteLine("error");
        }
        else if (profit >= 0 && profit <= 500)
        {
            Console.WriteLine($"{(profit * 4.5 / 100):f2}");
        }
        else if (profit > 500 && profit <= 1000)
        {
            Console.WriteLine($"{(profit * 7.5 / 100):f2}");
        }
        else if (profit > 1000 && profit <= 10000)
        {
            Console.WriteLine($"{(profit * 10 / 100):f2}");
        }
        else if (profit > 10000)
        {
            Console.WriteLine($"{(profit * 13 / 100):f2}");
        }
        break;
    case "Plovdiv":
        if (profit < 0)
        {
            Console.WriteLine("error");
        }
        else if (profit >= 0 && profit <= 500)
        {
            Console.WriteLine($"{(profit * 5.5 / 100):f2}");
        }
        else if (profit > 500 && profit <= 1000)
        {
            Console.WriteLine($"{(profit * 8 / 100):f2}");
        }
        else if (profit > 1000 && profit <= 10000)
        {
            Console.WriteLine($"{(profit * 12 / 100):f2}");
        }
        else if (profit > 10000)
        {
            Console.WriteLine($"{(profit * 14.5 / 100):f2}");
        }
        break;

    default:
        Console.WriteLine("error"); break;
}