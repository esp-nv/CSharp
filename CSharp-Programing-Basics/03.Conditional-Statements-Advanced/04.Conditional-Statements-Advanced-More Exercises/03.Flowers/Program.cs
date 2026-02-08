//03.Flowers

int countHrizantemi = int.Parse(Console.ReadLine());
int countRoses  = int.Parse(Console.ReadLine());
int countLaleta = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
char praznik = char.Parse(Console.ReadLine());

double priceAll = 0.0;
double percentUp = 0.0;

if (praznik == 'Y')
{
    percentUp = 1.15;    
}
else if (praznik == 'N')
{
    percentUp = 1.0;
}

switch (season)
{
    case "Spring":
    case "Summer":
        priceAll = ((countHrizantemi * 2.0) + (countRoses * 4.1) + (countLaleta * 2.5)) * percentUp;
        break;
    case "Autumn":
    case "Winter":
       priceAll = ((countHrizantemi * 3.75) +(countRoses * 4.5) + (countLaleta * 4.15)) * percentUp;
       break ;

}

double priceDiscount = 0.0;

if (countLaleta > 7 && season == "Spring")
{
    priceDiscount = 0.95;
}
else if (countRoses >= 10 && season == "Winter" )
{
    priceDiscount = 0.9;
}
else
{
    priceDiscount = 1;
}
  
if (countRoses + countLaleta + countHrizantemi >= 20)
{
    priceDiscount = 2+ ((priceAll * priceDiscount) * 0.8);
    Console.WriteLine($"{priceDiscount:f2}");
}
else
{
    priceDiscount = 2+ priceAll * priceDiscount;
    Console.WriteLine($"{priceDiscount:f2}");
}

