//09.Ski Trip

//input
int day = int.Parse(Console.ReadLine());
string typeRoom = Console.ReadLine();
string grade = Console.ReadLine();

double pricePerOne = 18.00;
double priceApartment = 25.00;
double pricePresident = 35.00;
double discount = 0.0;
double totalPrice = 0.0;

//calculate
switch(typeRoom)
    {
    case "room for one person":
        discount = pricePerOne*1.0;
        break;
    case "apartment":
         switch (day)
         {
            case <10: discount = 0.7 * priceApartment; break;
            case >= 10 and <= 15: discount = 0.65* priceApartment; break;
            case > 15: discount = 0.5* priceApartment; break;   
         }

        break;
    case "president apartment":
        switch (day)
        {
            case < 10: discount = 0.9 * pricePresident; break;
            case >= 10 and <= 15: discount = 0.85 * pricePresident; break;
            case > 15: discount = 0.8 * pricePresident; break;
        }

        break ;

}

switch (grade)
{
    case "positive": 
        totalPrice= ((day-1)*discount)*1.25;
        break;
    case "negative":
        totalPrice = ((day - 1) * discount) * 0.9;
        break;
}

//output
Console.WriteLine($"{totalPrice:f2}");