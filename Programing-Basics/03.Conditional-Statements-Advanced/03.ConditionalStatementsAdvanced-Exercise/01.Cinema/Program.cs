// 01. Cinema

// input
string projection = Console.ReadLine();
int row = int.Parse(Console.ReadLine());
int column = int.Parse(Console.ReadLine());

//output
if  (projection == "Premiere" )
{
    Console.WriteLine($"{(row*column*12):f2} leva");
}
else  if (projection == "Normal")
{
    Console.WriteLine($"{(row * column * 7.5):f2} leva");
}
else if (projection == "Discount")
{
    Console.WriteLine($"{(row * column * 5.0):f2} leva");
}