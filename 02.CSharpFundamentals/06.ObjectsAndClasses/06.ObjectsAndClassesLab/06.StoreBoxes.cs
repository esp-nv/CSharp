using System;
using System.Collections.Generic;

namespace _06.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] boxInfo = input.Split();
                string serialNumber = boxInfo[0];
                string itemName = boxInfo[1];
                int itemQuantity = int.Parse(boxInfo[2]);
                decimal itemPrice = decimal.Parse(boxInfo[3]);

                Item item = new Item
                {
                    Name = itemName,
                    Price = itemPrice
                };

                Box box = new Box
                {
                    SerialNumber = serialNumber,
                    ItemName = item,
                    ItemQuantity = itemQuantity,
                    ItemPrice = itemPrice
                };

                boxes.Add(box);
            }

            boxes.Sort((b1, b2) => (GetCompareBoxes(b1, b2)));

            foreach (Box box in boxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.ItemName.Name} - ${box.ItemPrice:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.ItemPrice * box.ItemQuantity:f2}");
            }
        }

        static int GetCompareBoxes(Box b1, Box b2)
        {
            decimal total1 = b1.ItemPrice * b1.ItemQuantity;
            decimal total2 = b2.ItemPrice * b2.ItemQuantity;

            if (total1 > total2)
                return -1; // b1 трябва да е преди b2
            else if (total1 < total2)
                return 1;  // b2 трябва да е преди b1
            else
                return 0;

        }

        public class Box
        {
            public string SerialNumber { get; set; }
            public Item ItemName { get; set; }
            public int ItemQuantity { get; set; }
            public decimal ItemPrice { get; set; }
        }

        public class Item
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
        }
    }
}
