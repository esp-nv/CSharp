//04. Vegetable Market
//Градинар продавал реколтата от градината си на зеленчуковата борса.
//Продава зеленчуци за N лева на килограм и плодове за M лева за килограм.
//
//Напишете програма, която да пресмята приходите от реколтата в евро
//( ако приемем, че едно евро е равно на 1.94лв).

//Вход
//От конзолата се четат 4 числа, по едно на ред:
//•	Първи ред – Цена за килограм зеленчуци – реално число[0.00… 1000.00]
//•	Втори ред – Цена за килограм плодове – реално число[0.00… 1000.00]
//•	Трети ред – Общо килограми на зеленчуците – цяло число[0… 1000]
//•	Четвърти ред – Общо килограми на плодовете – цяло число[0… 1000]

//Изход
//Да се отпечата на конзолата едно число: приходите от всички плодове и зеленчуци в евро.
//Резултата да се форматира до втория знак след десетичния разделител.

//input
double vegPrice = double.Parse(Console.ReadLine());
double fruitPrice = double.Parse(Console.ReadLine());
double sumVegKg = double.Parse(Console.ReadLine()); 
double sumFruitKg = double.Parse(Console.ReadLine());

//calculate
double totalSum = (vegPrice * sumVegKg) + (fruitPrice*sumFruitKg);
double totalSumPerEuro = totalSum/1.94;

//output
Console.WriteLine($"{totalSumPerEuro:f2}");