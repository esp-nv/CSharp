//7.	Доставка на храна
//Ресторант отваря врати и предлага няколко менюта на преференциални цени: 
//•	Пилешко меню –  10.35 лв. 
//•	Меню с риба – 12.40 лв. 
//•	Вегетарианско меню  – 8.15 лв. 

//Напишете програма, която изчислява
//колко ще струва на група хора да си поръчат храна за вкъщи.
//Групата ще си поръча и десерт,
//чиято цена е равна на 20% от общата сметка (без доставката). 
//Цената на доставка е 2.50 лв и се начислява най-накрая.

//Вход
//От конзолата се четат 3 реда:
//•	Брой пилешки менюта – цяло число в интервала [0 … 99]
//•	Брой менюта с риба – цяло число в интервала [0 … 99]
//•	Брой вегетариански менюта – цяло число в интервала [0 … 99]

//Изход
//Да се отпечата на конзолата един ред:  "{цена на поръчката}"

//input
double chikenPrice = 10.35;
double fishPrice = 12.40;
double veganPrice = 8.15;
double desertPricePercent = 20;
double deliveryPrice = 2.50;

int countChiken = int.Parse(Console.ReadLine());
int countFish = int.Parse(Console.ReadLine());
int countVegan = int.Parse(Console.ReadLine());

//calculate
double amountChiken = countChiken * chikenPrice;
double amountFish = countFish * fishPrice;
double amountVegan = countVegan * veganPrice;
double totalAmountMenu =amountChiken + amountFish+amountVegan;
double amountDesert = totalAmountMenu * desertPricePercent / 100;
double totalSum = totalAmountMenu + amountDesert + deliveryPrice;

//output
Console.WriteLine(totalSum);
