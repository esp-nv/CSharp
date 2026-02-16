//06.Truck Driver
string season = Console.ReadLine();
double kmPerMonth  = double.Parse(Console.ReadLine());

double price = 0.0;

switch (kmPerMonth)
{
    case <= 5000.0:
        if(season == "Spring" || season== "Autumn")
        {
            price = (kmPerMonth * 0.75);

        }
        else if(season == "Summer")
        {
            price = (kmPerMonth * 0.9);
        }
        else if (season == "Winter")
        {
            price = (kmPerMonth * 1.05);
        }
        break;
    case > 5000.0 and <= 10000:
        if (season == "Spring" || season == "Autumn")
        {
            price = (kmPerMonth * 0.95);
        }
        else if (season == "Summer")
        {
            price = (kmPerMonth * 1.10);
        }
        else if (season == "Winter")
        {
            price = (kmPerMonth * 1.25);
        }
        break;
    case > 10000 and <= 20000:
        price = (kmPerMonth * 1.45) ;
        break;
}

double zaplata = (price * 4) * 0.9;
Console.WriteLine($"{zaplata:f2}");