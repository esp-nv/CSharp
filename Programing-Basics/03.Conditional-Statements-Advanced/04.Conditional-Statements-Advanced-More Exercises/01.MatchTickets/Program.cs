//01.Match Tickets
double budget = double.Parse(Console.ReadLine());
string category  = Console.ReadLine();
int countPeople = int.Parse(Console.ReadLine());

double price = 0.0;
double percent = 0.0;

switch (category) 
    {
    case "VIP":price = 499.99;
        break;
    case "Normal": price = 249.99;
        break;
}
if (countPeople < 5)
{
    percent = 0.75;
}
else if (countPeople >= 5 && countPeople <10)
{
    percent = 0.60;
}
else if (countPeople >= 10 && countPeople < 25)
{
    percent = 0.50;
}
else if (countPeople >= 25 &&  countPeople <50)
{
    percent = 0.40;
}
else if (countPeople >= 50)
{
    percent = 0.25;
}
double transportPrice = budget * percent;
double razhod =budget - transportPrice;
double priceTicket = price * countPeople;

if (priceTicket < razhod)
{
    Console.WriteLine($"Yes! You have {Math.Abs(priceTicket - razhod):f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {Math.Abs(priceTicket -razhod):f2} leva.");

}

