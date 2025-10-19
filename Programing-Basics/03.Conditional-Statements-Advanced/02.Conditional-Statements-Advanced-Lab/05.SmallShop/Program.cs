//05.Small Shop

//град          coffee  water	beer	sweets	peanuts
//Sofia     	0.50	0.80	1.20	1.45	1.60
//Plovdiv    	0.40	0.70	1.15	1.30	1.50
//Varna     	0.45	0.70	1.10	1.35	1.55

//Напишете програма, която чете 
//    продукт (низ), град (низ) и количество (десетично число), 
//    въведени от потребителя, и пресмята и отпечатва 
//    колко струва съответното количество от избрания продукт в посочения град. 

string product = Console.ReadLine();
string city  = Console.ReadLine();
double qty = double.Parse(Console.ReadLine());

if (city == "Sofia")
{
    switch (product)
    {
        case "coffee": Console.WriteLine($"{qty * 0.5}"); break;
        case "water": Console.WriteLine($"{qty * 0.8}"); break;
        case "beer": Console.WriteLine($"{qty * 1.2}"); break;
        case "sweets": Console.WriteLine($"{qty * 1.45}"); break;
        case "peanuts": Console.WriteLine($"{qty * 1.6}"); break;

    }
}
else if (city == "Plovdiv")
{
    switch (product)
    {
        case "coffee": Console.WriteLine($"{qty * 0.4}"); break;
        case "water": Console.WriteLine($"{qty * 0.7}"); break;
        case "beer": Console.WriteLine($"{qty * 1.15}"); break;
        case "sweets": Console.WriteLine($"{qty * 1.3}"); break;
        case "peanuts": Console.WriteLine($"{qty * 1.5}"); break;

    }
}
else if (city == "Varna")
{
    switch (product)
    {
        case "coffee": Console.WriteLine($"{qty * 0.45}"); break;
        case "water": Console.WriteLine($"{qty * 0.7}"); break;
        case "beer": Console.WriteLine($"{qty * 1.1}"); break;
        case "sweets": Console.WriteLine($"{qty * 1.35}"); break;
        case "peanuts": Console.WriteLine($"{qty * 1.55}"); break;

    }
}