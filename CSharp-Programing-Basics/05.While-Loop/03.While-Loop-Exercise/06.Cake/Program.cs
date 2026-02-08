//06.Cake
int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

int cakePieces =width * length;

while (true)
{
    string input = Console.ReadLine();
     if(input == "STOP")
    {
        break;
    }
     int currPieces = int.Parse(input);
    cakePieces -= currPieces;
    if (cakePieces < 0)
    {
        break ;
    }

}

if (cakePieces >= 0)
{

    Console.WriteLine($"{cakePieces} pieces are left.");
}
else
{
    Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");
}
