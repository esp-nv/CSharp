//04.Sequence 2k + 1
int n = int.Parse(Console.ReadLine());

int currNum = 1;

while (currNum <= n)
{
    Console.WriteLine(currNum);
    currNum= currNum * 2 + 1;
}
