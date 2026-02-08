//07.Football League
int capacitetStadium = int.Parse(Console.ReadLine());
int countFens= int.Parse(Console.ReadLine());

int countA = 0;
int countB = 0;
int countV = 0;
int countG = 0;

for (int i = 1; i <= countFens; i++)
{
    char nameSector = char.Parse(Console.ReadLine());

    switch (nameSector)
    {
        case 'A': countA++; break;
        case 'B': countB++; break;
        case 'V': countV++; break;
        case 'G': countG++; break;
    }
}

Console.WriteLine($"{(double)countA / countFens*100:f2}%");
Console.WriteLine($"{(double)countB / countFens * 100:f2}%");
Console.WriteLine($"{(double)countV / countFens * 100:f2}%");
Console.WriteLine($"{(double)countG / countFens * 100:f2}%");
Console.WriteLine($"{(double)countFens / capacitetStadium * 100:f2}%");