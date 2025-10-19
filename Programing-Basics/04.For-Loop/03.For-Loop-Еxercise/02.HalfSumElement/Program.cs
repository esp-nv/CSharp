//02.Half Sum Element

int n = int.Parse(Console.ReadLine());

int sum = 0;
int maxValue = int.MinValue;

for (int i = 1; i <= n; i++)
{
    int currNum = int.Parse(Console.ReadLine());

    sum += currNum;

    if (currNum > maxValue)
    {
        maxValue = currNum;
    }
}

int sumTotal = sum - maxValue;

if(maxValue == sumTotal)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {maxValue}");
}
else
{
    int diff = maxValue - sumTotal;
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(diff)}");
}


