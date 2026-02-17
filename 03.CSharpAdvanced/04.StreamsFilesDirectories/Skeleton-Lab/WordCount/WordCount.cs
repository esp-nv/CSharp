namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {

            string[] wordReader = File.ReadAllText(wordsFilePath).Split();
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (string word in wordReader)
            {
                if (!dic.ContainsKey(word))
                {
                    dic.Add(word, 0);
                }

            }

           // string pattern = @"(?<words>[A-Za-z]+)";

            Regex regex = new Regex(@"(?<words>[A-Za-z]+)");

            var textReader = File.ReadAllText(textFilePath);
            string[] maches = regex.Matches(textReader).Select(m => m.Groups["words"].Value.ToLower()).ToArray();
            foreach (var found in dic.Keys)
            {
                for (int i = 0; i < maches.Length; i++)
                {
                    if (found == maches[i])
                    {
                        dic[found]++;
                    }
                }
            }
            string output = string.Empty;
            
            foreach (var word in dic.OrderByDescending(x=>x.Value))
            {
                
                output+=$"{word.Key} - {word.Value}"+Environment.NewLine;
            }
            
            File.WriteAllText(outputFilePath,output);

        }
    }
}
