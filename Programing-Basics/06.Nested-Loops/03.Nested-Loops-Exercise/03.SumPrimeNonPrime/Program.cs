//03.Sum Prime Non Prime

string input = "";
int primeSum = 0;
int nonPrimeSum = 0;

while ((input = Console.ReadLine()) != "stop")
{
    int num = int.Parse(input);

    if (num < 0)
    {
        Console.WriteLine("Number is negative.");
        continue;
    }

    bool isPrime=true;

    if (num <= 1)
    {
        isPrime = false;
    }
    else if ((num != 2) && (num % 2 == 0))
    {
        isPrime = false;
    }
    else
    {

        for (int i = 3; i <= Math.Sqrt(num); i += 2)
        {
            if (num%i == 0)
            { 
                isPrime = false;
                break;
            }
        }

    }

    if (isPrime)
    {
        primeSum += num;
    }
    else
    {
        nonPrimeSum += num;
    }
}

Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");