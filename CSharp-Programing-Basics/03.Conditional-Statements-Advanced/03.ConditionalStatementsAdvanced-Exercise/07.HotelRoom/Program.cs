//07.Hotel Room

//input 
string month = Console.ReadLine();
int countNight =int.Parse(Console.ReadLine());

double priceApartment = 0.0;
double priceStudio = 0.0;
double discountApartment = 0.0;
double discountStudio = 0.0;

// get price for month
switch (month)
{
    case "May" or "October":
        priceApartment = 65.00;
        priceStudio = 50.00;
        break;
    case "June" or "September":
        priceApartment = 68.70;
        priceStudio = 75.20;
        break;
    case "July" or "August":
        priceApartment = 77.00;
        priceStudio = 76.00;
        break ;
}
//get discount for month
if (month == "May" || month == "October")
{
    if (countNight <= 7)
    {
        discountStudio = 1.0;
    }
    else if (countNight <= 14)
    {
        discountStudio = 0.95;
    }
    else if (countNight > 14)
    {
        discountStudio = 0.7;
    }

}
else if (month == "June" || month == "September")
{
    if (countNight > 14)
    {
        discountStudio = 0.8;
    }
    else
    {
        discountStudio = 1.0;
    }
}
else
{
    discountStudio = 1.0;
}

if (countNight <= 14)
{
    discountApartment = 1.0;
}
else
{
    discountApartment = 0.9;
}

//calculate
double apartment =(priceApartment * discountApartment) * countNight;
double studio = (priceStudio * discountStudio) * countNight;

//output 
Console.WriteLine($"Apartment: {apartment:f2} lv.");
Console.WriteLine($"Studio: {studio:f2} lv.");