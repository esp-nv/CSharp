//04.Grades

int countStudents =int.Parse(Console.ReadLine());

int countTop = 0;
int countGood = 0;
int countBad = 0;
int countFail = 0;
double sumAllGrade = 0.0;

for (int i = 0; i < countStudents; i++)
{
    double grade = double.Parse(Console.ReadLine());
    sumAllGrade += grade;
    if (grade < 3.00)
    {
        countFail++;

    }
    else if (grade >= 3.00 && grade < 4.00)
    {
        countBad++;
    }
    else if (grade >= 4.00 && grade < 5.00)
    {
        countGood++;
    }
    else if (grade >= 5.00)
    {
        countTop++;
    }
    
}

Console.WriteLine($"Top students: {((double)countTop/countStudents)*100:f2}%");
Console.WriteLine($"Between 4.00 and 4.99: {((double)countGood / countStudents) * 100:f2}%");
Console.WriteLine($"Between 3.00 and 3.99: {((double)countBad / countStudents) * 100:f2}%");
Console.WriteLine($"Fail: {((double)countFail / countStudents) * 100:f2}%");
Console.WriteLine($"Average: {sumAllGrade/countStudents:f2}");