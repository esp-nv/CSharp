//07.Trekking Mania
int groupsCount =int.Parse(Console.ReadLine());

int peopleCount = 0;
int peopleMusala = 0;
int peopleMonblan = 0;
int peopleKilimangaro = 0;
int peopleK2 = 0;
int peopleEverest = 0;

for (int i = 1; i <= groupsCount; i++)
{
    int currPeopleCount = int.Parse(Console.ReadLine());
    peopleCount += currPeopleCount;

    if (currPeopleCount <= 5)
    {
        peopleMusala += currPeopleCount;
    }
    else if (currPeopleCount >= 6 && currPeopleCount <= 12)
    {
        peopleMonblan += currPeopleCount;
    }
    else if (currPeopleCount >= 13 && currPeopleCount <= 25)
    {
        peopleKilimangaro += currPeopleCount;
    }
    else if (currPeopleCount>=26 && currPeopleCount<=40)
    {
        peopleK2 += currPeopleCount;
    }
    else if (currPeopleCount >= 41)
    {
        peopleEverest += currPeopleCount;
    }

}
double percentMusala = (double)peopleMusala / peopleCount * 100;
Console.WriteLine($"{percentMusala:f2}%");

double percentMonblan = (double)peopleMonblan / peopleCount * 100;
Console.WriteLine($"{percentMonblan:f2}%");

double percentKilimangaro = (double)peopleKilimangaro / peopleCount * 100;
Console.WriteLine($"{percentKilimangaro:f2}%");

double percentK2 = (double)peopleK2 / peopleCount *100;
Console.WriteLine($"{percentK2:f2}%");

double percentEverest = (double)peopleEverest / peopleCount *100;
Console.WriteLine($"{percentEverest:f2}%");
