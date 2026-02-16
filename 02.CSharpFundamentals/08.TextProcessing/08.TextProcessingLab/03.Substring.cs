using System;
using System.Text;

namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string substring = Console.ReadLine();
            string text = Console.ReadLine();
           
            int index = text.IndexOf(substring);
          
            while (index != -1)
            {
                text = text.Remove(index, substring.Length);
                index = text.IndexOf(substring);
            }
          
            Console.WriteLine(text);
        }
    }
}
