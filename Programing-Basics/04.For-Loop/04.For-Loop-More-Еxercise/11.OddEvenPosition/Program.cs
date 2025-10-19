//11.Odd / Even Position
int couuntNum = int.Parse(Console.ReadLine());

double oddSum = 0;
double oddMin = double.MaxValue;
double oddMax = double.MinValue;
double evenSum = 0;
double evenMin = double.MaxValue;
double evenMax = double.MinValue;

for (int i = 1; i <= couuntNum; i++)
{
    double num = double.Parse(Console.ReadLine());
    if (i % 2 != 0)
    {
        oddSum += num;

        if (num < oddMin)
        {
            oddMin = num;

        }
        if (num > oddMax)
        {
            oddMax = num;
        }
    }
    else
    {
        evenSum += num;
        if (num < evenMin)
        {
            evenMin = num;
        }
        if (num > evenMax)
        {
            evenMax = num;
        }
    }
}
Console.WriteLine($"OddSum={oddSum:f2},");

if (oddSum != 0)
{
    Console.WriteLine($"OddMin={oddMin:f2},");
    Console.WriteLine($"OddMax={oddMax:f2},");
}
else
{
    Console.WriteLine("OddMin=No,");
    Console.WriteLine("OddMax=No,");
}

Console.WriteLine($"EvenSum={evenSum:f2},");
if (evenSum != 0)
{
    Console.WriteLine($"EvenMin={evenMin:f2},");
    Console.WriteLine($"EvenMax={evenMax:f2}");
}
else
{
    Console.WriteLine("EvenMin=No,");
    Console.WriteLine("EvenMax=No");
}
