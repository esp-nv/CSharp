namespace OddLines
{
    using System;
    using System.IO;

    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            var reader = new StreamReader(inputFilePath);

            //variant 1
            int count = 0;
            using var writer = new StreamWriter(outputFilePath);
            while (true)
            {
                var line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                if (count % 2 == 1)
                {
                    // Console.WriteLine(line);
                    writer.WriteLine(line);
                }
                count++;
            }

            //variant 2
            //using (reader)
            //{
            //    int counter = 0;
            //    string line = reader.ReadLine();
            //    using (var writer = new StreamWriter(outputFilePath))
            //    {
            //        while (line != null)
            //        {
            //            if (counter % 2 == 1)
            //            {
            //                writer.Write(line);
            //            }
            //            counter++;
            //            line = reader.ReadLine();
            //        }
            //    }
            //}
        }
    }
}
