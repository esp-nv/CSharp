using System;

namespace _10_RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGame = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());

            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount = 0;

            for (int i = 1; i <= lostGame; i++)
            {

                if (i % 2 == 0)
                {
                    headsetCount++;
                }

                if (i % 3 == 0)
                {
                    mouseCount++;
                }

                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardCount++;

                    if (keyboardCount % 2 == 0)
                    {
                        displayCount++;
                    }
                }
            }

            decimal expenses = headsetCount * headsetPrice + mouseCount * mousePrice + keyboardCount * keyboardPrice + displayCount * displayPrice;
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");

        }
    }
}
