//01.Number Pyramid
int n  = int.Parse(Console.ReadLine());
int currFloor = 1;
bool isBigger = false;

for (int rows = 1; rows <= n; rows++)
{
    for (int cols = 1; cols <= rows; cols++)
    {
        if (currFloor > n)
        {
            isBigger = true;
            break;
        }
        Console.Write(currFloor+" ");
        currFloor++;
    }
    Console.WriteLine();

}