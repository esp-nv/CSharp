//04.Transport Price

//input

using System.Diagnostics.CodeAnalysis;

int km = int.Parse(Console.ReadLine());
string dayTime = Console.ReadLine();

double taxiStart = 0.7;
double dayTaxi = 0.79;
double nightTaxi = 0.9;
double bus = 0.09;
double train = 0.06;

double sum = 0.0;

//calculate
if (km < 20)
{
    if (dayTime == "day")
    {
        sum = (dayTaxi * km) + taxiStart;
    }
    else if (dayTime == "night")
    {
        sum = (nightTaxi * km) + taxiStart;
    }

}
else if (km >= 20 && km < 100)
{
    sum = (bus * km);
}
else if (km >= 100)
{
    sum = train * km;
}

//output
Console.WriteLine($"{sum:f2}");