﻿//4.Познай паролата
//Да се напише програма, която чете парола (текст), въведена от потребителя и
//проверява дали въведената парола съвпада с фразата "s3cr3t!P@ssw0rd".

//При съвпадение да се изведе "Welcome".
//При несъвпадение да се изведе "Wrong password!". 

string pass = Console.ReadLine();
if (pass != "s3cr3t!P@ssw0rd")
{
    Console.WriteLine("Wrong password!");
}
else
{
    Console.WriteLine("Welcome");
}