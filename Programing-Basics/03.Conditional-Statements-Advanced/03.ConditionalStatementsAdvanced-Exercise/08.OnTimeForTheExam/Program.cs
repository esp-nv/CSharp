//08.On Time for the Exam

// input
using System.Diagnostics.Metrics;

int hourExam = int.Parse(Console.ReadLine());
int minExam  = int.Parse(Console.ReadLine());
int hourArrival  = int.Parse(Console.ReadLine());
int minArrival  = int.Parse(Console.ReadLine());

//calculate
double exam = (hourExam*60) + minExam;
double arrival = (hourArrival * 60) + minArrival;
double result = 0.0;




if (exam == arrival)
{
    Console.WriteLine("On time");

}
else if (exam < arrival)
{
    result = arrival - exam;
    Console.WriteLine("Late");
    if (result <= 59)
    {
       Console.WriteLine($"{result} minutes after the start");
    }
    else 
    {
        int hourLate =(int)result / 60;
        int minLate = (int)result % 60;
        // Console.WriteLine(hourLate);
        // Console.WriteLine(minLate);
        if (minLate <10)
        {
            Console.WriteLine($"{hourLate}:0{minLate} hours after the start");
        }
        else
        {
            Console.WriteLine($"{hourLate}:{minLate} hours after the start");
        }
       
    }
}
else if (exam > arrival)
{
    //Console.WriteLine("Late");
    result = exam - arrival;
    if (result <= 30)
    {
        Console.WriteLine("On time");
        Console.WriteLine($"{result} minutes before the start");
    }
    else if (result > 30)
    {
        Console.WriteLine("Early");
        int hourEarly = (int)result / 60;
        int minEarly = (int)result % 60;
        // Console.WriteLine(hourEarly);
        // Console.WriteLine(minEarly);
        if (hourEarly <1)
        {
            Console.WriteLine($"{result} minutes before the start");
        }
        else if (minEarly< 10) 
        
        {

            Console.WriteLine($"{hourEarly}:0{minEarly} hours before the start");
        }
        else
        {
            Console.WriteLine($"{hourEarly}:{minEarly} hours before the start");
        }
    }
}




