
//Напишете програма, която изчислява колко часа ще са необходими на един архитект,
//за да изготви проектите на няколко строителни обекта. Изготвянето на един проект отнема три часа.

//Вход
//От конзолата се четат 2 реда:
//1.	Името на архитекта - текст
//2.	Брой на проектите, които трябва да изготви - цяло число в интервала [0 … 100]

//Изход
//На конзолата се отпечатва:
//•	"The architect {името на архитекта} will need {необходими часове} hours to complete {брой на проектите} project/s."

string nameArchitect = Console.ReadLine();
int countProjects=int.Parse(Console.ReadLine());

int hoursProjects = countProjects * 3;

Console.WriteLine($"The architect {nameArchitect} will need {hoursProjects} hours to complete {countProjects} project/s.");
