using System;

namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] arr = Console.ReadLine().Split(' ');

            string[] reversedArr = new string[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                reversedArr[i] = arr[arr.Length - 1 - i];
            }

            for (int i = 0; i < reversedArr.Length; i++)
            {
                Console.Write(reversedArr[i] + " ");
            }
        }
    }
}
