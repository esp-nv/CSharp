//01.Back To The Past
double money = double.Parse(Console.ReadLine());
int year = int.Parse(Console.ReadLine());

int n = 18;

for (int i = 1800; i <= year; i++)
{
 
    if (i %2 == 0)
    {
        money = money - 12000;
    }
    if (i %2 !=0) 
    {
        money =money - (12000+(n*50));
    }
   n++;
    
}

if (money<0)
{
    Console.WriteLine($"He will need {Math.Abs(money):f2} dollars to survive.");
}
else
{
    Console.WriteLine($"Yes! He will live a carefree life and will have {money:f2} dollars left.");
}

