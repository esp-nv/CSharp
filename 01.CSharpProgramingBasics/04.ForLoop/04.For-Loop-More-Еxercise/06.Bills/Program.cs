//06.Bills
int countMonth = int.Parse(Console.ReadLine());

double waterBill = 20.0;
double internetBill = 15.0;
double otherBill = 1.2;

double waterAllBill = 0;
double internetAllBill = 0;
double otherAllBill = 0;
double electricityAllBill = 0.0;



for (int i = 1; i <= countMonth; i++)
{
     double electricityBill = double.Parse(Console.ReadLine());

    waterAllBill += waterBill;
    internetAllBill += internetBill;
    otherAllBill += (electricityBill+waterBill+internetBill)*otherBill;
    electricityAllBill += electricityBill;

}

double avgAllBill=(electricityAllBill + waterAllBill + internetAllBill + otherAllBill) /countMonth;

Console.WriteLine($"Electricity: {electricityAllBill:f2} lv");
Console.WriteLine($"Water: {waterAllBill:f2} lv");
Console.WriteLine($"Internet: {internetAllBill:f2} lv");
Console.WriteLine($"Other: {otherAllBill:f2} lv");
Console.WriteLine($"Average: {avgAllBill:f2} lv");