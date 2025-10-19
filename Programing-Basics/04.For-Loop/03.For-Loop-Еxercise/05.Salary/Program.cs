//05.Salary

int openTab = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());
string nameTab = "";

for (int i = 1; i <=openTab; i++)
{
    nameTab = Console.ReadLine();
    if(nameTab == "Facebook")
    {
       salary = salary - 150;
    // Console.WriteLine(salary);

    }
    else if (nameTab == "Instagram")
    {
        salary = salary - 100;
  //    Console.WriteLine(salary);
    }
    else if (nameTab == "Reddit")
    {
        salary = salary - 50;
    //  Console.WriteLine(salary);
    }
    if (salary <= 0)
    {
        Console.WriteLine("You have lost your salary.");
        break;
    }

    

}
if (salary > 0)
{
    Console.WriteLine(salary);
    
}
