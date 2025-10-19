//03.Time15Minutes
//Да се напише програма, която чете час и минути от 24-часово денонощие, 
//    въведени от потребителя и изчислява колко ще е часът след 15 минути. 
//    Резултатът да се отпечата във формат часове:минути.Часовете винаги са между 0 и 23, 
//    а минутите винаги са между 0 и 59. Часовете се изписват с една или две цифри. 
//    Минутите се изписват винаги с по две цифри, с водеща нула, когато е необходимо.
//    
//Input
int hours = int.Parse(Console.ReadLine());
int minute = int.Parse(Console.ReadLine());

//Calculate
if (minute >= 45)
{
    hours++;
    minute = (minute + 15) % 60;
}
else
{
    minute += 15;
}

if (hours == 24)
{
    hours = 0;
}

//Output
if (minute < 10)
{
    Console.WriteLine($"{hours}:0{minute}");
}
else
{
    Console.WriteLine($"{hours}:{minute}");
}