namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {

            var files = Directory.GetFiles(folderPath);

            var totallenght = 0m; ;

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);

                totallenght = fileInfo.Length;

            }
           // Console.WriteLine(totallenght/1024);
            File.WriteAllText(outputFilePath,$"{totallenght / 1024 } KB");
        }
    }
}
