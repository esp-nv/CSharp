//Напишете програма, която пресмята нужните разходи за закупуването на храна за кучета и котки.
//Храната се пазарува от зоомагазин, като една опаковка храна за кучета е на цена 2.50 лв,
//а опаковка храна за котки струва 4 лв.

//Вход
//От конзолата се четат 2 реда:
//1.	Броят на опаковките храна за кучета – цяло число в интервала [0… 100]
//2.	Броят на опаковките храна за котки –  цяло число в интервала [0… 100]

//Изход
//На конзолата се отпечатва: 
//"{крайната сума} lv."

int countDogsFood= int.Parse(Console.ReadLine());
int countCatsFood= int.Parse(Console.ReadLine());

double priceDogsFood = countDogsFood * 2.50;
double priceCatsFood = countCatsFood * 4.00;

double priceSum = priceDogsFood + priceCatsFood;
Console.WriteLine($"{priceSum} lv.");
