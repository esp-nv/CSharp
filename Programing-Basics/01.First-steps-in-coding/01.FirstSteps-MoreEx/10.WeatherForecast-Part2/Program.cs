//10.Weather Forecast - Part 2
double degree = double.Parse(Console.ReadLine());

if (degree >= 5 && degree<12)
{
    Console.WriteLine("Cold");
}
else if (degree >=12 &&  degree<15)
{
    Console.WriteLine("Cool");
}
else if (degree >= 15 && degree <= 20)
{
    Console.WriteLine("Mild");
}
else if (degree > 20 && degree <26)
{
    Console.WriteLine("Warm");
}
else if (degree >= 26 && degree < 35)
{
    Console.WriteLine("Hot");
}
else
{
    Console.WriteLine("unknown");
}