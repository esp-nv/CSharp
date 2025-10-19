//04.Train The Trainers
int juriCount = int.Parse(Console.ReadLine());

int presentationCount = 0;
double allGradeSum = 0;
double currGradeSum= 0;
string presentationName = "";

while((presentationName=Console.ReadLine()) != "Finish")
{
    presentationCount++;
    for(int i = 1; i <= juriCount; i++)
    {
        double grade = double.Parse(Console.ReadLine());
        currGradeSum += grade;
        allGradeSum += grade;
    }
    double avgGrade = currGradeSum/juriCount;
    currGradeSum = 0;
    Console.WriteLine($"{presentationName} - {avgGrade:f2}.");
}

double avgGradeAll = allGradeSum/(presentationCount*juriCount);

Console.WriteLine($"Student's final assessment is {avgGradeAll:f2}.");
