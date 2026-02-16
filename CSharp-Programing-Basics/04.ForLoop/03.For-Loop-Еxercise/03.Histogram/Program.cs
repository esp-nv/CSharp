//03.Histogram

int n = int.Parse(Console.ReadLine());

double p1Count = 0.0;
double p2Count = 0.0;
double p3Count = 0.0;
double p4Count = 0.0;
double p5Count = 0.0;

for (int i = 1; i <= n; i++)
{
    int currNum = int.Parse(Console.ReadLine());

    if (currNum < 200)
    {
        p1Count++;
    }
    else if (currNum >= 200 && currNum <= 399)
    {
        p2Count++;
    }
    else if (currNum >= 400 && currNum <= 599)
    {
        p3Count++;
    }
    else if (currNum >= 600 && currNum <= 799)
    {
        p4Count++;
    }
    else if ((currNum >= 800))
    {
        p5Count++;
    }
}

Console.WriteLine($"{(p1Count / n * 100):f2}%");
Console.WriteLine($"{(p2Count / n * 100):f2}%");
Console.WriteLine($"{(p3Count / n * 100):f2}%");
Console.WriteLine($"{(p4Count / n * 100):f2}%");
Console.WriteLine($"{(p5Count / n * 100):f2}%");