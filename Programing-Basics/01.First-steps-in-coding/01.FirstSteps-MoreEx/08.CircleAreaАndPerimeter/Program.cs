//08.Circle Area and Perimeter

double r = double.Parse(Console.ReadLine());


double area = Math.PI * r * r;
double perimeter = 2 * r * Math.PI;

Console.WriteLine($"{area:f2}");
Console.WriteLine($"{perimeter:f2}");
