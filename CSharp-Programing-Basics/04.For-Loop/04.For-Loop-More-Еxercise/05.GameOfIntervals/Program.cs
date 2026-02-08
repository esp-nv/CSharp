//05.Game Of Intervals

int counntGame = int.Parse(Console.ReadLine());

double allPoint = 0.0;
int pointToNine = 0;
int pointToNineteen = 0;
int pointToTwentyNine =0;
int pointToThirtyNine = 0;
int pointToFifty = 0;
int pointToNegative = 0;


for (int i = 1; i <= counntGame; i++)
{
    int hodove  = int.Parse(Console.ReadLine());

    if (hodove < 0)
    {
        allPoint = allPoint / 2;
        pointToNegative++;
    }
    else if (hodove >= 0 && hodove < 10)
    {
        allPoint += hodove * 0.2;
        pointToNine++;

    }
    else if (hodove >= 10 && hodove < 20)
    {
        allPoint += hodove * 0.3;
        pointToNineteen++;
    }
    else if (hodove >= 20 && hodove < 30)
    {
        allPoint += hodove * 0.4;
        pointToTwentyNine++;
    }
    else if (hodove >= 30 && hodove < 40)
    {
        allPoint += 50;
        pointToThirtyNine++;
    }
    else if (hodove >=40 && hodove <= 50)
    {
        allPoint += 100;
        pointToFifty++;
    }
    else if (hodove >= 50)
    {
        allPoint = allPoint/2;
        pointToNegative++;
    }
}

Console.WriteLine($"{allPoint:f2}");
Console.WriteLine($"From 0 to 9: {((double)pointToNine/counntGame)*100:f2}%");
Console.WriteLine($"From 10 to 19: {((double)pointToNineteen / counntGame) * 100:f2}%");
Console.WriteLine($"From 20 to 29: {((double)pointToTwentyNine / counntGame) * 100:f2}%");
Console.WriteLine($"From 30 to 39: {((double)pointToThirtyNine / counntGame) * 100:f2}%");
Console.WriteLine($"From 40 to 50: {((double)pointToFifty / counntGame) * 100:f2}%");
Console.WriteLine($"Invalid numbers: {((double)pointToNegative / counntGame) * 100:f2}%");
