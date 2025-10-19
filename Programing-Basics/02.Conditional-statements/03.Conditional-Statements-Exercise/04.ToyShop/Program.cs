//04. Toy Shop
//Петя има магазин за детски играчки. Тя получава голяма поръчка, която трябва да изпълни.
//С парите, които ще спечели иска да отиде на екскурзия. 
//Цени на играчките:
//•	Пъзел - 2.60 лв.            //•	Говореща кукла - 3 лв.
//•	Плюшено мече - 4.10 лв.     //•	Миньон - 8.20 лв.
//•	Камионче - 2 лв.
//Ако поръчаните играчки са 50 или повече магазинът прави отстъпка 25% от общата цена.
//От спечелените пари Петя трябва да даде 10% за наема на магазина.
//
//Да се пресметне дали парите ще ѝ стигнат да отиде на екскурзия.
//Вход
//От конзолата се четат 6 реда:
//1.	Цена на екскурзията - реално число в интервала [1.00 … 10000.00] travelCount
//2.	Брой пъзели - цяло число в интервала [0… 1000] mazelCount
//3.	Брой говорещи кукли - цяло число в интервала [0 … 1000] dollCount
//4.	Брой плюшени мечета - цяло число в интервала [0 … 1000] bearCount
//5.	Брой миньони - цяло число в интервала [0 … 1000] minionCount
//6.	Брой камиончета - цяло число в интервала [0 … 1000] carCount
//Изход
//На конзолата се отпечатва:
//•	Ако парите са достатъчни се отпечатва:
//o	"Yes! {оставащите пари} lv left."
//•	Ако парите НЕ са достатъчни се отпечатва:
//o	"Not enough money! {недостигащите пари} lv needed."

//input
double travelPrice =double.Parse(Console.ReadLine());
int mazelCount=int.Parse(Console.ReadLine());
int dollCount  =int.Parse(Console.ReadLine());
int bearCount =int.Parse(Console.ReadLine());
int minionCount =int.Parse(Console.ReadLine());
int carCount =int.Parse(Console.ReadLine());


//calulate
double bill = (mazelCount*2.6) + (dollCount*3.0) + (bearCount*4.10) + (minionCount*8.2) + (carCount*2.0);
int sumCount = mazelCount+dollCount+bearCount+minionCount+carCount;
double profit = 0.0;

if (sumCount >= 50)
{
    double discountBill = (bill * 0.25);
    double rent = (bill- discountBill)*0.1;
    profit= bill-discountBill-rent;
}
else
{
    double rent = (bill * 0.1);
    profit = bill - rent;
}


//output
if(profit >= travelPrice)
{
    double leftMoney = profit - travelPrice;
    Console.WriteLine($"Yes! {leftMoney:f2} lv left.");
}
else
{
    double needMoney = travelPrice - profit;
    Console.WriteLine($"Not enough money! {needMoney:f2} lv needed.");
}
