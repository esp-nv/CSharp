//01.Dishwasher
int countDetergent = int.Parse(Console.ReadLine());
string currCount = Console.ReadLine();

int allDetergent = countDetergent * 750 ;
int sumDetergent = 0;
int allSadove = 0;
int countPots = 0;
int countDish = 0;

while (currCount != "End")
{
    int currSadove = int.Parse(currCount);
    
    allSadove++;
    if (allSadove % 3 == 0)
    {
        sumDetergent += currSadove * 15;
        countDish += currSadove;
    }
    else
    {
        sumDetergent += (currSadove * 5);
        countPots += currSadove;
    }

    if (sumDetergent > allDetergent)
    {
        Console.WriteLine($"Not enough detergent, {sumDetergent - allDetergent} ml. more necessary!");
        break;
    }
    else
    {
        currCount = Console.ReadLine();
    }
}
if (currCount == "End")
{
    Console.WriteLine("Detergent was enough!");
    Console.WriteLine($"{countPots} dishes and {countDish} pots were washed.");
    Console.WriteLine($"Leftover detergent {allDetergent-sumDetergent} ml.");

}
