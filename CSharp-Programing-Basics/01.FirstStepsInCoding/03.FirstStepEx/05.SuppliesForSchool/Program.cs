//5.	Учебни материали

//Учебната година вече е започнала и отговорничката на 10Б клас -
//Ани трябва да купи определен брой пакетчета с химикали,
//пакетчета с маркери, //както и препарат за почистване на дъска.
//Тя е редовна клиентка на една книжарница, затова има намаление за нея,
//което представлява някакъв процент от общата сума.
//
//Напишете програма, която изчислява
//колко пари ще трябва да събере Ани, за да плати сметката,
//като имате предвид следния ценоразпис: 
//•	Пакет химикали - 5.80 лв. 
//•	Пакет маркери - 7.20 лв. 
//•	Препарат - 1.20 лв (за литър)

//Вход
//От конзолата се четат 4 числа:
//•	Брой пакети химикали - цяло число в интервала [0...100]
//•	Брой пакети маркери - цяло число в интервала [0...100]
//•	Литри препарат за почистване на дъска - цяло число в интервала [0…50]
//•	Процент намаление - цяло число в интервала [0...100]

//Изход
//Да се отпечата на конзолата колко пари ще са нужни на Ани, за да си плати сметката.

double pens = 5.80;
double marker = 7.20;
double cleaner = 1.20;

int penPack = int.Parse(Console.ReadLine());
int markerPack  = int.Parse(Console.ReadLine());
int cleanPack  = int.Parse(Console.ReadLine());
int discount  = int.Parse(Console.ReadLine());

double penPrice = penPack * pens;
double markerPrice = markerPack * marker;
double cleanerPrice = cleanPack * cleaner;
double totalSum = penPrice + markerPrice + cleanerPrice;
double discountPrice = totalSum * discount / 100;
double totalAmount = totalSum - discountPrice;

Console.WriteLine(totalAmount);



