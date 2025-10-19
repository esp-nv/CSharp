//01.SumSeconds

int firstPlayer = int.Parse(Console.ReadLine());
int secondPlayer= int.Parse(Console.ReadLine());
int thirdPlayer= int.Parse(Console.ReadLine());

int timeInSeconds = firstPlayer + secondPlayer + thirdPlayer;
int minutes = timeInSeconds / 60; //124 / 60 = 2 minutes
int seconds = timeInSeconds % 60; //124 % 60 =4 minuti

if (seconds < 10)
{
    Console.WriteLine($"{minutes}:0{seconds}");
}
else
{
    Console.WriteLine($"{minutes}:{seconds}");
}