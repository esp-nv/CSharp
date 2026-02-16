//08.Fuel Tank - Part 2

using System.Runtime.CompilerServices;

string typeGorivo = Console.ReadLine();
double litri = double.Parse(Console.ReadLine());
string card = Console.ReadLine();

double priceGasoline = 2.22;
double priceDiesel = 2.33;
double priceGas = 0.93;

double discount = 0.0;

switch (card)
{
    case "Yes":
        switch (typeGorivo)
        {
            case "Diesel":
                discount = (priceDiesel - 0.12) *litri;
                break;
            case "Gasoline":
                discount = (priceGasoline - 0.18) * litri;
                break;
            case "Gas":
                discount = (priceGas - 0.08)*litri;
                break;
        }

        break;
    case "No":
        switch (typeGorivo)
        {
            case "Diesel":
                discount = priceDiesel *litri;
                break;
            case "Gasoline": 
                discount = priceGasoline *litri;
                break;
            case "Gas":
                discount =priceGas * litri;
                break;
        }
        break;
}


if (litri < 20)
{
    Console.WriteLine($"{discount:f2} lv.");
}  
else if(litri>=20 && litri <= 25)
{
    double sum= discount*0.92;
    Console.WriteLine($"{sum:f2} lv.");
}
else if (litri > 25)
{
    double sum = discount * 0.9;
    Console.WriteLine($"{sum:f2} lv.");
}
