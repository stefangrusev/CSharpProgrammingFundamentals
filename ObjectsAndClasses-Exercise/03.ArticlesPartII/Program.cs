using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ArticlesPartII
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            var diffArticles = new List<Article>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] articleInfo = Console.ReadLine().Split(", ");
                Article Article = new Article(articleInfo[0], articleInfo[1], articleInfo[2]);
                diffArticles.Add(Article);
            }

            string format = Console.ReadLine();
            if (format == "title") { diffArticles = diffArticles.OrderBy(art => art.Title).ToList(); }
            else if (format == "content") { diffArticles = diffArticles.OrderBy(art => art.Content).ToList(); }
            else if (format == "author") { diffArticles = diffArticles.OrderBy(art => art.Author).ToList(); }

            foreach (var currArticle in diffArticles)
            {
                Console.WriteLine(currArticle);
            }
        }
    }



    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString() => $"{Title} - {Content}: {Author}";

    }
}
