//04.Clever Lily

int age = int.Parse(Console.ReadLine());
double priceWashingMashine  = double.Parse(Console.ReadLine());
int priceToy = int.Parse(Console.ReadLine());

int toyCount = 0;
int money = 0;
int moneyIntake = 0;

for (int i = 1; i <= age; i ++)
{
    if(i % 2 == 1)
    {
        toyCount++;
    }
    else
    {
        moneyIntake += 10;
        money  += moneyIntake;

        money -= 1; //money--;
    }

}

money +=toyCount*priceToy;

if (money >= priceWashingMashine)
{
    double diff = (money - priceWashingMashine);
    Console.WriteLine($"Yes! {diff:f2}");
}
else
{
    double leftMoney = priceWashingMashine - money;
    Console.WriteLine($"No! {leftMoney:f2}");
}