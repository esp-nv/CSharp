//7.Лица на фигури
//Да се напише програма, в която потребителят въвежда вида и размерите на геометрична фигура и пресмята лицето й.
//Фигурите са четири вида: квадрат(square), правоъгълник(rectangle), кръг(circle) и триъгълник(triangle).
//
//На първия ред на входа се чете вида на фигурата (текст със следните възможности: square, rectangle, circle или triangle). 
//•	Ако фигурата е квадрат (square): на следващия ред се чете едно дробно число - дължина на страната му
//•	Ако фигурата е правоъгълник (rectangle): на следващите два реда четат две дробни числа - дължините на страните му
//•	Ако фигурата е кръг (circle): на следващия ред чете едно дробно число - радиусът на кръга
//•	Ако фигурата е триъгълник (triangle): на следващите два реда четат две дробни числа - дължината на страната му и дължината на височината към нея
//Резултатът да се закръгли до 3 цифри след десетичната запетая. 

string figure = Console.ReadLine();

if (figure== "square")
{
    double sideA = double.Parse(Console.ReadLine());
    double area = sideA * sideA;

    Console.WriteLine("{0:f3}", area);
}
else if (figure== "rectangle")
{
    double sideA = double.Parse(Console.ReadLine());
    double sideB = double.Parse(Console.ReadLine());

    double area = sideA * sideB;
    Console.WriteLine("{0:f3}", area);
}
else if (figure== "circle")
{
    double radius = double.Parse(Console.ReadLine());
    double area = Math.PI * Math.Pow(radius, 2);
    Console.WriteLine("{0:f3}", area);

}
else if (figure== "triangle")
{
    double sideA = double.Parse(Console.ReadLine());
    double height = double.Parse(Console.ReadLine());
    double area = sideA * height /2;

    Console.WriteLine("{0:f3}", area);
}


