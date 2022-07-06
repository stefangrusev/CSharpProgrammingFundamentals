using System;
using System.Linq;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            var articleInfo = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).ToList();
            int numberOfCommands = int.Parse(Console.ReadLine());

            Article article = new Article(articleInfo[0], articleInfo[1], articleInfo[2]);

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(": ",StringSplitOptions.RemoveEmptyEntries);

                if (command[0]=="Edit")
                {
                    article.Edit(command[1]);
                }
                else if (command[0]=="ChangeAuthor")
                {
                    article.ChangeAuthor(command[1]);
                }
                else if (command[0]=="Rename")
                {
                    article.Rename(command[1]);
                }
            }

            Console.WriteLine(article);

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

        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString() => $"{Title} - {Content}: {Author}";

    }
}
