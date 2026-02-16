using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Articles
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
            public void Rename(string title)
            {
                Title = title;
            }
            public void Edit(string content)
            {
                Content = content;
            }
            public void ChangeAuthor(string author)
            {
                Author = author;
            }
            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }

        static void Main(string[] args)
        {

            string[] firstInput = Console.ReadLine().Split(", ");
            string title = firstInput[0];
            string content = firstInput[1];
            string author = firstInput[2];

            Article article = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandParts = Console.ReadLine().Split(": ");

                string commandPart = commandParts[0];
                string text = commandParts[1];

                switch (commandPart)
                {
                    case "Edit":
                        article.Edit(text);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(text);
                        break;
                    case "Rename":
                        article.Rename(text);
                        break;
                }
            }

            Console.WriteLine(article);
        }
    }
}
