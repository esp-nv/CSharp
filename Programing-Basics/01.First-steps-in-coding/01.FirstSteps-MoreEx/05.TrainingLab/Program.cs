// 05.Training Lab

//input
double widthPerMeter = double.Parse(Console.ReadLine());
double heightPerMeter = double.Parse(Console.ReadLine());

//calculate
int heightPerSm = (int)((heightPerMeter * 100) -100); //приспадане на коридор от 100см
int height = heightPerSm / 70;
int widthPerSm = (int)(widthPerMeter * 100);
int width = widthPerSm /120;
int total=(width * height) -3; // заети от входна врата и катедра

//output
Console.WriteLine(total);