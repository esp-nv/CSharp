using System;

namespace _01.DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string type = Console.ReadLine();
                switch (type)
                {
                    case "int":
                        int intValue = int.Parse(Console.ReadLine());
                        Console.WriteLine(intValue * 2);
                        break;
                    case "real":
                        double realValue = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{realValue * 1.5:F2}");
                        break;
                    case "string":
                        string strValue = Console.ReadLine();
                        Console.WriteLine($"${strValue}$");
                        break;
                    default:
                        Console.WriteLine("Unknown type");
                        break;
            }
        }
    }
}
