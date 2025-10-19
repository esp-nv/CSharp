//05.Account Balance

string intput = Console.ReadLine();
double sum = 0;

while (intput != "NoMoreMoney")
{
    double payment = double.Parse(intput);
    if(payment < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }

    Console.WriteLine($"Increase: {payment:f2}");
    sum += payment;

    intput = Console.ReadLine();
}
Console.WriteLine($"Total: {sum:f2}");
