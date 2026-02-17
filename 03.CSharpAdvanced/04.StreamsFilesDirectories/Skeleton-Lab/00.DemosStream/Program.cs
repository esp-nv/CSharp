using System;
using System.IO;
using System.Linq;
using System.Text;

namespace _00.DemosStream
{
    internal class Program
    {
        static void Main()
        {

            var files = Directory.GetFiles(".");

            var totallenght = 0m;;

            foreach (var file in files) 
            {
                var fileInfo = new FileInfo(file);

                totallenght += fileInfo.Length;

            }
            Console.WriteLine($"{ totallenght/1024/1024}");           
        }
    }
}
