// 07. House Painting

double x = double.Parse(Console.ReadLine()); //височината на къщата – реално число в интервала [2...100]
double y = double.Parse(Console.ReadLine()); //дължината на страничната стена – реално число в интервала [2...100]
double h = double.Parse(Console.ReadLine()); //височината на триъгълната стена на прокрива – реално число в интервала [2...100]

double greenRazhod = 3.4;
double redRazhod = 4.3;
double door = 1.2 * 2;
double window = 2 * 1.5 * 1.5;

double steniKvadrat = 2 * x * x -door;
double steniPravoagalnik= 2 * x * y - window;
double areaSteni =steniKvadrat + steniPravoagalnik;
double totalGreen = areaSteni/greenRazhod;

double pokrivPravoagalnik = 2 * x * y;
double pokrivTriagalnik = x * h;
double areaPokrov = pokrivPravoagalnik + pokrivTriagalnik;
double totalRed = areaPokrov/redRazhod;

Console.WriteLine($"{totalGreen:f2}");
Console.WriteLine($"{totalRed:f2}");

