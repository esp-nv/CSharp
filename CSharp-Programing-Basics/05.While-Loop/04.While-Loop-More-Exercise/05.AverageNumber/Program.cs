//05.Average Number
int n = int.Parse(Console.ReadLine());

double sumTotal = 0;

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    sumTotal += num;
}
double avgTotal = sumTotal / n;
Console.WriteLine($"{avgTotal:f2}");