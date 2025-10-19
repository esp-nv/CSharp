//02.Exam Preparation


int maxPoorGrades = int.Parse(Console.ReadLine());

int poorGragesCounter = 0;
int problemCounter = 0;
int allGrades = 0;
string lastProblem = "";

string nameOfProblem = Console.ReadLine();


while (nameOfProblem != "Enough")
{
    int currGrade =int.Parse(Console.ReadLine());

    problemCounter++;

    if (currGrade <= 4)
    {
        poorGragesCounter++;
        if(poorGragesCounter == maxPoorGrades)
        {
            Console.WriteLine($"You need a break, {maxPoorGrades} poor grades.");
            break;
        }

    }

    allGrades += currGrade;
    lastProblem = nameOfProblem;
    nameOfProblem = Console.ReadLine();
}

if (nameOfProblem == "Enough")
{
    double avaredeGrade = (double) allGrades / problemCounter;

    Console.WriteLine($"Average score: {avaredeGrade:f2}");
    Console.WriteLine($"Number of problems: {problemCounter}");
    Console.WriteLine($"Last problem: {lastProblem}");
}
