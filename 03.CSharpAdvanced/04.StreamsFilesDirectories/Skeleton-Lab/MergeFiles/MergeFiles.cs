namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            string[] text1 = File.ReadAllLines(firstInputFilePath);
            string[] text2 = File.ReadAllLines(secondInputFilePath);

            var maxLen= Math.Max(text1.Length,text2.Length);

            for (int i = 0; i < maxLen; i++)
            { 
                if (i <= text1.Length )                
                {
                    File.AppendAllText(outputFilePath, text1[i]);
                    Console.WriteLine(text1[i]);
                }
                if (i <= text2.Length)                
                {
                    File.AppendAllText(outputFilePath, text2[i]);
                    Console.WriteLine(text2[i]);
                }
            }
        }
    }
}
