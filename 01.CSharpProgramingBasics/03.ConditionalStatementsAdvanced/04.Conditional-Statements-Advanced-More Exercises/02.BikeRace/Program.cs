//02.Bike Race
int countJunior = int.Parse(Console.ReadLine());
int countSenior=int.Parse(Console.ReadLine());
string traceTrip  = Console.ReadLine();

double price = 0.0;

switch (traceTrip)
{
    case "trail": 
        price = countJunior * 5.5 + countSenior * 7.0;
        break;
    case "cross-country":
        if (countJunior + countSenior >= 50)
        {

            price = (countJunior * 8.0 + countSenior * 9.5) -((countJunior * 8.0 + countSenior * 9.5)*0.25);
        }
        else
        {
            price = countJunior * 8.0 + countSenior * 9.5;
        }
       
        break;
    case "downhill":
        price = countJunior * 12.25 + countSenior * 13.75;
        break;
    case "road":
        price = countJunior * 20.0 + countSenior * 21.5;
        break;

}

double sumLeft = price - (price * 0.05);
Console.WriteLine($"{sumLeft:f2}");