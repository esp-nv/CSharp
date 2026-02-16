// 04. Fishing Boat

//input
int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishmen = int.Parse(Console.ReadLine());

// prices
double rent = 0.0;
double bill = 0.0;
double discount = 0.0;


//calculate

if (fishmen <= 6)
{
    discount = 0.9;
}
else if (fishmen > 6 && fishmen <= 11)
{
    discount = 0.85;
}
else if (fishmen > 11)
{
    discount = 0.75;
}
//Console.WriteLine(discount);

switch (season)
{
    case "Spring":
        rent = 3000.00;
        if (fishmen % 2 == 0)
        {
            bill = (rent * discount) * 0.95;
        }
        else
        {
            bill = rent * discount;
        }
        break;
    case "Summer":
        rent = 4200.00;
        // bill = rent * discount;
        if (fishmen % 2 == 0)
        {
            bill = (rent * discount) * 0.95;
        }
        else
        {
            bill = rent * discount;
        }
        break;
    case "Autumn":
        rent = 4200.00;
        bill = rent * discount;
        break;
    case "Winter":
        rent = 2600.00;
        if (fishmen % 2 == 0)
        {
            bill = (rent * discount) * 0.95;
        }
        else
        {
            bill = rent * discount;
        }
        break;

}

//output
if (bill <= budget)
{
    double leftMoney = budget - bill;
    Console.WriteLine($"Yes! You have {leftMoney:f2} leva left.");
}
else if (bill > budget)
{
    double needMoney = bill - budget;
    Console.WriteLine($"Not enough money! You need {needMoney:f2} leva.");
}