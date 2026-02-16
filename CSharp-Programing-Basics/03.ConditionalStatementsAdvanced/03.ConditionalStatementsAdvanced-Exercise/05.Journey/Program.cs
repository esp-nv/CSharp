// 05. Journey

//input

double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

double bill = 0;
string destination = "";
string rest = "";
// “Bulgaria", "Balkans” и ”Europe”
//  или "winter"
//calulate
if (budget <= 100)
{
     destination = "Bulgaria";
   switch (season)
    {
        case "summer":
            rest = "Camp";
            bill = budget * 30 / 100;
            break;
        case "winter":
            rest = "Hotel";
            bill = budget * 70 / 100;
            break;
    }
}
else if (budget <= 1000)
{
    destination = "Balkans";
    switch (season)
    {
        case "summer":
            rest = "Camp";
            bill = budget * 40 / 100;
            break;
        case "winter":
            rest = "Hotel";
            bill = budget * 80 / 100;
            break;
    }
}
else if (budget > 1000)
{
   destination = "Europe"; 
   bill = budget * 90 / 100;
   rest = "Hotel";
   
}

//output
Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{rest} - {bill:f2}");
