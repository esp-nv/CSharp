using System;
using System.Text;

namespace _05.HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string article = Console.ReadLine();

            string div = "";
            StringBuilder finalOutput = new StringBuilder();
            finalOutput.AppendLine("<h1>");
            finalOutput.AppendLine($"    {title}");
            finalOutput.AppendLine("</h1>");
            finalOutput.AppendLine("<article>");
            finalOutput.AppendLine($"    {article}");
            finalOutput.AppendLine("</article>");

            while ((div = Console.ReadLine()) != "end of comments")
            {
                finalOutput.AppendLine("<div>");
                finalOutput.AppendLine($"    {div}");
                finalOutput.AppendLine("</div>");
            }

            Console.WriteLine(finalOutput.ToString().Trim());
        }
    }
}
