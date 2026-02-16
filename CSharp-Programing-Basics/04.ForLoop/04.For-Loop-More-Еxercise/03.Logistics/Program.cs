//03.Logistics
int countTovari = int.Parse(Console.ReadLine());

int allTone = 0;
int toneVan = 0;
int toneTruck = 0;
int toneTrain = 0;
for (int i = 1; i <= countTovari; i++)
{
    int tone=int.Parse(Console.ReadLine());
    if (tone <= 3)
    {
        allTone += tone ;
        toneVan += tone;
    }
    else if (tone > 3 && tone <= 11)
    { 
        toneTruck += tone;
        allTone += tone;
    }
    else if ( tone > 11)
    {
        toneTrain += tone;
        allTone += tone;
    }

}

double priceVan = toneVan * 200.0;
double priceTruck = toneTruck * 175.0;
double priceTrain = toneTrain * 120.0;
double allPrice = (priceVan + priceTruck + priceTrain)/allTone;
Console.WriteLine($"{allPrice:f2}");
Console.WriteLine($"{((double)toneVan / allTone)*100:f2}%");
Console.WriteLine($"{((double)toneTruck / allTone)*100:f2}%");
Console.WriteLine($"{((double)toneTrain / allTone)*100:f2}%");
