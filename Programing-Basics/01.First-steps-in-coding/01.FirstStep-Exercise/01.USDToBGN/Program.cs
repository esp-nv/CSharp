﻿//Напишете програма за конвертиране на щатски долари (USD) в български лева (BGN).
//Използвайте фиксиран курс между долар и лев: 1 USD = 1.79549 BGN.

double usd = double.Parse(Console.ReadLine());

double convert = usd * 1.79549;

Console.WriteLine(convert);