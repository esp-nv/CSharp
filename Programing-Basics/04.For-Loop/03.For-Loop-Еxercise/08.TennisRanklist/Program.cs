//08.Tennis Ranklist
int turnirCount = int.Parse(Console.ReadLine());
int initialPoint = int.Parse(Console.ReadLine());

int point = 0;
int winCount = 0;

for (int i = 1; i <= turnirCount; i++)
{
    string turnirResult = Console.ReadLine();
    if (turnirResult == "W")
    {
        point += 2000;
        winCount++;
    }
    else if (turnirResult == "F")
    {
        point += 1200;

    }
    else if (turnirResult == "SF")
    {
        point += 720;
    }
}
double avgPoint = (double) point / turnirCount;
point += initialPoint;
double winPercent = (double) winCount / turnirCount * 100;

Console.WriteLine($"Final points: {point}");
Console.WriteLine($"Average points: {Math.Floor(avgPoint)}");
Console.WriteLine($"{winPercent:f2}%");