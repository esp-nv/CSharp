//03.Vacation
double moneyTrip = double.Parse(Console.ReadLine());
double savedMoney = double.Parse(Console.ReadLine());

int allDaysCounter = 0;
int spendDaysCounter = 0;

while (savedMoney < moneyTrip)
{
    string whatJessyDo = Console.ReadLine(); //"spend" or "save""
    double currMoney = double.Parse(Console.ReadLine());

    allDaysCounter++;

    if (whatJessyDo == "spend")
    {
        spendDaysCounter ++;
        savedMoney -= currMoney;

        if (savedMoney < 0)
        {
            savedMoney = 0;
        }
        if (spendDaysCounter == 5)
        {
            Console.WriteLine("You can't save the money.");
            Console.WriteLine($"{allDaysCounter}");
            break;
        }
    }
    else if (whatJessyDo == "save")
    {
        spendDaysCounter = 0;
        savedMoney += currMoney;

    }
}

if (savedMoney >= moneyTrip)
{
    Console.WriteLine($"You saved the money for {allDaysCounter} days.");
}