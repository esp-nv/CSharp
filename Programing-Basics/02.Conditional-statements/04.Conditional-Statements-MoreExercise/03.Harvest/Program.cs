//03.Harvest

//input
int loze = int.Parse(Console.ReadLine());
double grozde = double.Parse(Console.ReadLine());
int needPerVino = int.Parse(Console.ReadLine());
int worker = int.Parse(Console.ReadLine());

double needGrozde = 2.5;
//calculate
double totalGrozde= loze * grozde;
double vino = (totalGrozde*0.4) /needGrozde;

//output
if (needPerVino > vino)
{
    double leftVino =needPerVino-vino;
    
    Console.WriteLine($"It will be a tough winter! More {Math.Floor(leftVino):f0} liters wine needed.");
   
}
else
{
    double needVino = (vino - needPerVino);
    double needVinoPerWorker = needVino / worker;
    Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(vino):f0} liters.");
   Console.WriteLine($"{Math.Ceiling(needVino):f0} liters left -> {Math.Ceiling(needVinoPerWorker):f0} liters per person.");
}
