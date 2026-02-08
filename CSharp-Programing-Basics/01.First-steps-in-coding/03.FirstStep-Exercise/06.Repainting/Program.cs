//6.	Пребоядисване

//Румен иска да пребоядиса хола и за целта е наел майстори.
//
//Напишете програма, която изчислява разходите за ремонта, предвид следните цени:
//•	Предпазен найлон - 1.50 лв. за кв. метър
//•	Боя - 14.50 лв. за литър
//•	Разредител за боя - 5.00 лв. за литър
//За всеки случай, към необходимите материали,
//Румен иска да добави още 10% от количеството боя и 2 кв.м. найлон, разбира се и 0.40 лв. за торбички.
//Сумата, която се заплаща на майсторите за 1 час работа, е равна на 30% от сбора на всички разходи за материали.
//
//Вход
//Входът се чете от конзолата и съдържа точно 4 реда:
//1.	Необходимо количество найлон (в кв.м.) - цяло число в интервала [1... 100] nylon
//2.	Необходимо количество боя (в литри) - цяло число в интервала [1…100] paint
//3.	Количество разредител (в литри) - цяло число в интервала [1…30] thinner
//4.	Часовете, за които майсторите ще свършат работата - цяло число в интервала [1…9] hour
//
//Изход
//Да се отпечата на конзолата един ред:
//•	"{сумата на всички разходи}"

//input
double priceNylon = 1.50;
double pricePaint = 14.50;
double priceThinner = 5.00;
int addNylon = 2;
double percentPaint = 10;
double package = 0.40;
double percentMaster = 30;

int nylon = int.Parse(Console.ReadLine());
int paint = int.Parse(Console.ReadLine());
int thinner = int.Parse(Console.ReadLine());
int hour = int.Parse(Console.ReadLine());

//calulate
double sumNylon = (nylon + addNylon) * priceNylon;
double sumPaint = (paint+ (paint*percentPaint/100)) * pricePaint;
double sumThinner = thinner * priceThinner;
double totalSumMaterial = sumNylon + sumPaint + sumThinner + package;
double sumMaster = (totalSumMaterial*percentMaster/100)*hour;
double totalAmount = totalSumMaterial + sumMaster;

//output
Console.WriteLine(totalAmount);

