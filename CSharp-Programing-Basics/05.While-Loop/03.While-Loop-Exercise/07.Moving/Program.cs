//07.Moving
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

string text = Console.ReadLine();

int cartonAll = width * height * length;

int cartonSum = 0;

while (text != "Done")
{
    int currCarton=int.Parse(text);
    cartonSum += currCarton;

    if (cartonSum > cartonAll)
    {
        Console.WriteLine($"No more free space! You need {cartonSum-cartonAll} Cubic meters more.");
        break;   
    }

    text = Console.ReadLine();
}

if (text == "Done")
{
    Console.WriteLine($"{cartonAll-cartonSum} Cubic meters left.");
}