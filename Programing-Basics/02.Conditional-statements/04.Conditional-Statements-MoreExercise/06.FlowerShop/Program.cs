//06.Flower Shop

int countMagnolii = int.Parse(Console.ReadLine());
int countZumbuli  = int.Parse(Console.ReadLine());
int countRoses = int.Parse(Console.ReadLine());
int countCactus = int.Parse(Console.ReadLine());
double priceGift = double.Parse(Console.ReadLine());

double priceMagnolii = countMagnolii * 3.25;
double priceZumbuli = countZumbuli * 4.0;
double priceRoses = countRoses * 3.5;
double priceCactus = countCactus * 8.0;

double sumWithoutDiscount = priceMagnolii + priceZumbuli + priceRoses + priceCactus;
double sumTotal = sumWithoutDiscount *0.95;

if (priceGift <= sumTotal)
{
    double leftPrice = sumTotal- priceGift;
    Console.WriteLine($"She is left with {Math.Floor(leftPrice):f0} leva.");
}
else
{
    double borrowPrice = priceGift - sumTotal;
    Console.WriteLine($"She will have to borrow {Math.Ceiling(borrowPrice)} leva.");
}