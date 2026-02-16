//04. Personal Titles

//input
double age = double.Parse(Console.ReadLine());
char gender =char.Parse(Console.ReadLine());

//output
if (gender == 'm')
{
    if (age >= 16)
    {
        Console.WriteLine("Mr.");
    }
    else if (age < 16)
    {
        Console.WriteLine("Master");
    }
}
else if (gender == 'f')
{
    if (age >= 16)
    {
        Console.WriteLine("Ms.");
    }
    else if (age < 16)
    {
        Console.WriteLine("Miss");
    }
}