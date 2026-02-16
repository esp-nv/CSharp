//08.Graduation
string studentName= Console.ReadLine();

int expelsClount = 0;
int yearsCount = 0;
double gradeSum = 0;

while (expelsClount <2 && yearsCount < 12)
{
    double grade=double.Parse(Console.ReadLine());
    yearsCount++;
    //изключен
    if (grade < 4)
    {
        expelsClount++;
        continue;
    }
    //преминава
    else
    {
        gradeSum += grade;
    }
}
//успешно завършен
if (expelsClount<2)
{
    double avaregeGrade = gradeSum / yearsCount;
    Console.WriteLine($"{studentName} graduated. Average grade: {avaregeGrade:f2}");
}
//не е завършил
else 
{
    Console.WriteLine($"{studentName} has been excluded at {yearsCount-1} grade");

}