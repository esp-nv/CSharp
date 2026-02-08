using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles2._0
{
    internal class Program
    {
        public class Article
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }
            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] articleParts = Console.ReadLine().Split(", ");
                string title = articleParts[0];
                string content = articleParts[1];
                string author = articleParts[2];
                Article article = new Article(title, content, author);
                articles.Add(article);
            }

            Console.WriteLine(string.Join("\n", articles));
        }
    }
}
