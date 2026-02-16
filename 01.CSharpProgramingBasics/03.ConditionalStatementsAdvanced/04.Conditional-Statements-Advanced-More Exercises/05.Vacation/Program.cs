//05.Vacation

double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

double price = 0.0;
string locationName = "";
string placeType = "";

switch (budget)
{
    case <= 1000.0:
        placeType = "Camp";
        if (season == "Summer")
        {
            locationName = "Alaska";
            price = budget * 0.65;
        }
        else if (season == "Winter")
        {
            locationName = "Morocco";
            price = budget * 0.45;
        }
        break;
    case > 1000.0 and <= 3000.0:
        placeType = "Hut";
        if (season == "Summer")
        {
            locationName = "Alaska";
            price = budget * 0.80;
        }
        else if (season == "Winter")
        {
            locationName = "Morocco";
            price = budget * 0.60;
        }
        break;
    case > 3000.0:
        placeType = "Hotel";
        price = budget * 0.90;
        if (season == "Summer")
        {
            locationName = "Alaska";
            
        }
        else if (season == "Winter")
        {
            locationName = "Morocco";
            
        }
        break;
}

Console.WriteLine($"{locationName} - {placeType} - {price:f2}");
