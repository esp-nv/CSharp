//04.Even Powers of 2

int num = int.Parse(Console.ReadLine());

for (int i = 0; i <= num; i+=2)
{
    Console.WriteLine(Math.Pow(2,i));
}