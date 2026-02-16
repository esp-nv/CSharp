//07.Fuel Tank

string typeGorivo = Console.ReadLine();
double litriRezervoar = double.Parse(Console.ReadLine());


if (litriRezervoar < 25)
{
    switch (typeGorivo)
    {
        case "Diesel":
            Console.WriteLine("Fill your tank with diesel!");
            break;
        case "Gasoline":
            Console.WriteLine("Fill your tank with gasoline!");
            break;
        case "Gas":
            Console.WriteLine("Fill your tank with gas!");
            break;
        default:
            Console.WriteLine("Invalid fuel!");
            break;
    }
}
else if (litriRezervoar >= 25)
{
    switch (typeGorivo)
    {
        case "Diesel":
            Console.WriteLine("You have enough diesel.");
            break;
        case "Gasoline":
            Console.WriteLine("You have enough gasoline.");
            break;
        case "Gas":
            Console.WriteLine("You have enough gas.");
            break;
        default:
            Console.WriteLine("Invalid fuel!");
            break;
    }

}
