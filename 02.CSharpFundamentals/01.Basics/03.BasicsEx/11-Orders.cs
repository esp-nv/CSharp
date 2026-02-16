using System;

namespace _11_Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int order = int.Parse(Console.ReadLine());

            decimal totalPrice = 0;

            for (int i = 0; i < order; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                int daysInMonth = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                decimal price = ((daysInMonth * capsulesCount) * pricePerCapsule);

                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                totalPrice += price;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
