//06.Max Number

string text = Console.ReadLine();

int max = int.MinValue;
while (text != "Stop")
{
    int num = int.Parse(text);
    if (num > max)
    {
        max = num;
    }
    text = Console.ReadLine();

}
Console.WriteLine(max);
