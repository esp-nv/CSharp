//06.Oscars
string actorName = Console.ReadLine();
double points = double.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

string nameOfAppraiser = "";
double pointsFromTheEvaluator = 0.0;

for (int i = 1; i <= n; i++)
{
    nameOfAppraiser = Console.ReadLine();
    pointsFromTheEvaluator = double.Parse(Console.ReadLine());

    points += nameOfAppraiser.Length * pointsFromTheEvaluator / 2;

    if (points >= 1250.5)
    {
        Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:F1}!");
        break;
    }
}
if (points < 1250.5)
{
    Console.WriteLine($"Sorry, {actorName} you need {1250.5 - points:F1} more!");
}