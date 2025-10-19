// 06. Fishland

double skumriaPrice = double.Parse(Console.ReadLine());
double cacaPrice = double.Parse(Console.ReadLine());
double palamudKg = double.Parse(Console.ReadLine());
double safridKg = double.Parse(Console.ReadLine());
int midiKg  = int.Parse(Console.ReadLine());

double palamudPrice = skumriaPrice * 1.6 ;
double safridPrice = cacaPrice * 1.8 ;
double midiPrice = 7.5;

double palamud = palamudPrice * palamudKg;
double safrid = safridPrice * safridKg;
double midi = midiPrice * midiKg;

double totalPrice = palamud + safrid + midi;

Console.WriteLine($"{totalPrice:f2}");