////02.Triangle Area
//Напишете програма, която чете от конзолата страна и височина на триъгълник и
//пресмята неговото лице.
//Използвайте формулата за лице на триъгълник: area = a * h / 2.
//Форматирате изхода до втория знак след десетичната запетая.

//input
double side = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());   

//calulate
double area = (side * height)/2;

//output
Console.WriteLine($"{area:f2}");