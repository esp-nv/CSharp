//04.Car To Go
double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

double price = 0.0;
string typeCar = "";
string classCar = "";

 switch(budget)
{ 
    case <= 100.0:
        classCar = "Economy class";
        if (season == "Summer")
        {
            typeCar = "Cabrio";
            price = budget * 0.35;
        }
        else if (season == "Winter")
        {
            typeCar = "Jeep";
            price = budget * 0.65;
        }
        break;
    case > 100.0 and <= 500.0:
        classCar = "Compact class";
        if (season == "Summer")
        {
            typeCar = "Cabrio";
            price = budget * 0.45;
        }
        else if (season == "Winter")
        {
            typeCar = "Jeep";
            price = budget * 0.80;
        }
        break;
    case > 500.0:
        classCar = "Luxury class";
        if (season == "Summer" || season == "Winter")
        {
            typeCar = "Jeep";
            price = budget * 0.90;
        }
        break;
}

Console.WriteLine(classCar);
Console.WriteLine($"{typeCar} - {price:f2}");