//02.Sleepy Tom Cat
int countRestDay =int.Parse(Console.ReadLine());

int playWorkDay = 63;
int playRestDay = 127;
int playPerYear = 30000;

//calculate
int playkRestDayTotal = countRestDay * playRestDay;
int countWorkDay = 365 - countRestDay;
int playWorkDayTotal = countWorkDay * playWorkDay;
int playTotal = playkRestDayTotal + playWorkDayTotal;
//int playRazlika = Math.Abs(playPerYear - playTotal);
//int hourPlay = playRazlika / 60;


//output
if (playTotal > playPerYear)
{
    int playLeft = playTotal - playPerYear;
    int h = playLeft / 60;
    int m = playLeft % 60;
    Console.WriteLine("Tom will run away");
    Console.WriteLine($"{h} hours and {m} minutes more for play");

}
else
{
    int playNeed = playPerYear - playTotal;
    int h = playNeed / 60;
    int m = playNeed % 60;
    Console.WriteLine($"Tom sleeps well");
    Console.WriteLine($"{h} hours and {m} minutes less for play");
}
