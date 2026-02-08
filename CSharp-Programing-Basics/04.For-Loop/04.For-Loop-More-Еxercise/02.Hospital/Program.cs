//02.Hospital
int days = int.Parse(Console.ReadLine());
int treated = 0;
int untreated = 0;
int doctors = 7;


for (int i = 1; i <= days; i++)
{
    int pacient = int.Parse(Console.ReadLine());
    if(i %3 == 0)
    {
        if (untreated > treated)
        {
            doctors++;
        }
  
    }
    if (pacient <= doctors)
    {
        treated += pacient;
    }
    else if (pacient > doctors)
    {
        untreated += pacient- doctors; 
        treated +=doctors;
    }

}

Console.WriteLine($"Treated patients: {treated}.");
Console.WriteLine($"Untreated patients: {untreated}.");