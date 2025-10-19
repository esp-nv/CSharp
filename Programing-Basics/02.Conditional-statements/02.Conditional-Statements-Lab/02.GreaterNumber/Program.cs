//2.По - голямото число
//Да се напише програма, която чете две цели числа въведени от потребителя и
//отпечатва по-голямото от двете. 


int num1 = int.Parse(Console.ReadLine());
int num2  = int.Parse(Console.ReadLine());

if (num1 >= num2)
{
    Console.WriteLine(num1);
}
else
{
    Console.WriteLine(num2);
}