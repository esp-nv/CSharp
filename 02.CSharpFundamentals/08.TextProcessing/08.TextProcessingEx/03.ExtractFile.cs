using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();
            string[] fileParts = filePath.Split("\\", StringSplitOptions.RemoveEmptyEntries);

            string fileNameWithExtension = fileParts.Last();
            string[] fileNameParts = fileNameWithExtension.Split(".", StringSplitOptions.RemoveEmptyEntries);
            string fileName = fileNameParts[0];
            string fileExtension = fileNameParts[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
