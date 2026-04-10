using System;
using System.Collections.Generic;
using System.Globalization;//za format na data-time format

using System.Linq;

using System.Threading;//za format na data-time format

namespace P00.CreateDataStructures
{
    public class Program
    {
        static void Main()
        {

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;// za format na data-time da ne dava greshki pri formata - ще взима датите и числата 
            var text = "Some text";

            var result = StringExtensions.ApplyWhiteSpace(text, 5);
            Console.WriteLine(result);

            text = StringExtensions.ApplyWhiteSpace(text);
            Console.WriteLine(text);

            var list = new MyListGeneric<int> { 1, 2, 3, 4 };


            var removed = list.RemoveAll(x => x % 2 == 0);

            Console.WriteLine(removed);

            Console.WriteLine(list[0]);  //1
            Console.WriteLine(list[1]);  //3

            Console.WriteLine(list.Count);  //2
        }
    }
}
