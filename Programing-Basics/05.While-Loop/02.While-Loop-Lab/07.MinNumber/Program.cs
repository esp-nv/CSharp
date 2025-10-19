//07.Min Number


string text = Console.ReadLine();

int min = int.MaxValue;
while (text != "Stop")
{
    int num = int.Parse(text);
    if (num < min)
    {
        min = num;
    }
    text = Console.ReadLine();

}
Console.WriteLine(min);
