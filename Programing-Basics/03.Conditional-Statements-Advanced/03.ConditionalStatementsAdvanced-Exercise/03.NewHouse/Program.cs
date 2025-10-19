//03. New House

// input

string typeFlower = Console.ReadLine();
int countFlower = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

//price flowers per Count
double rosesPrice = 5.0;
double dahliasPrice = 3.8;
double tulipsPrice = 2.8;
double narcissusPrice = 3.0;
double gladiolusPrice = 2.5;


double bill = 0.0;
//"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
switch (typeFlower)
{
    case "Roses":
        bill = rosesPrice * countFlower;
        if  (countFlower>80)
        {
         
            bill = bill * 0.9;
        }
        break;
    case "Dahlias":
        bill = dahliasPrice * countFlower;
        if (countFlower > 90)
        {

            bill = bill * 0.85;
        }
        break;
    case "Tulips":
        bill = tulipsPrice * countFlower;
        if (countFlower > 80)
        {

            bill = bill * 0.85;
        }
        break;
    case "Narcissus":
        bill = narcissusPrice * countFlower;
        if (countFlower < 120)
        {

            bill = bill * 1.15;
        }
               break;
    case "Gladiolus":
        bill = gladiolusPrice * countFlower;
        if (countFlower < 80)
        {

            bill = bill * 1.2;
        }
        break;
}
if (bill<=budget)
{
    double leftMoney = budget-bill;
    Console.WriteLine($"Hey, you have a great garden with {countFlower} {typeFlower} and {leftMoney:f2} leva left.");
}
else if (bill>budget)
{
    double needMoney = bill - budget;
    Console.WriteLine($"Not enough money, you need {needMoney:f2} leva more.");
}