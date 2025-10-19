//05.Pets

//input
int countDays = int.Parse(Console.ReadLine());
int leftFood  = int.Parse(Console.ReadLine());
double dogFoodKg = double.Parse(Console.ReadLine());
double catFoodKg = double.Parse(Console.ReadLine());
double turtleFoodGr  = double.Parse(Console.ReadLine());

//calucale
double dogFoodPerDays = countDays * dogFoodKg;
double catFoodPerDays = countDays * catFoodKg;
double turtleFoodPerDays = (countDays * turtleFoodGr) / 1000;

double sumTotalNeedFood = dogFoodPerDays + catFoodPerDays + turtleFoodPerDays;

if (sumTotalNeedFood < leftFood)
{
    double food = leftFood - sumTotalNeedFood;
    Console.WriteLine($"{Math.Floor(food):f0} kilos of food left.");
}
else
{
    double food = sumTotalNeedFood - leftFood;
    Console.WriteLine($"{Math.Ceiling(food):f0} more kilos of food are needed.");
}

