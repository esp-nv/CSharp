namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            //using FileStream partOne = new FileStream(partOneFilePath, FileMode.OpenOrCreate);
            // using FileStream partTwo = new FileStream(partTwoFilePath, FileMode.OpenOrCreate);

            // byte[] bytesImage = File.ReadAllBytes(sourceFilePath);
            using var streamImage = new FileStream(sourceFilePath, FileMode.Open);

            int parts = 2;

            var len = (int)Math.Ceiling(streamImage.Length / (double)parts);

            var buffer = new byte[len];
            for (int i = 0; i < parts; i++)
            {
                var bytesRead = streamImage.Read(buffer, 0, buffer.Length);
                if (bytesRead < buffer.Length)
                {
                    buffer = buffer.Take(bytesRead).ToArray();
                    using var currentPartsStream = new FileStream(partTwoFilePath, FileMode.Create);
                }
                else
                {
                    using var currentPartsStream = new FileStream(partOneFilePath, FileMode.Create);
                }
            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            
            using FileStream joinedFile = new FileStream(joinedFilePath, FileMode.OpenOrCreate);
            byte[] bytesPart = File.ReadAllBytes(partOneFilePath);

            joinedFile.Write(bytesPart);
            bytesPart = File.ReadAllBytes(partTwoFilePath);
            joinedFile.Write(bytesPart);
            joinedFile.Close();


        }
    }
}