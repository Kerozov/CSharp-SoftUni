using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_ArticlesTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var articles = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                string[] newArticle = Console.ReadLine().Split(new[] { ','} , StringSplitOptions.RemoveEmptyEntries);
                var article = new Article();
                article.Title = newArticle[0];
                article.Content = newArticle[1];
                article.Author = newArticle[2];
                articles.Add(article);
            }

            string order = Console.ReadLine();
            List<Article> list = new List<Article>();
            if (order == "title")
            {
               list = articles.OrderBy(o => o.Title).ToList();

            }
            else if (order =="content")
            {
                 list = articles.OrderBy(o => o.Content).ToList();
            }
            else if (order == "author")
            {
                 list = articles.OrderBy(o => o.Author).ToList();
            }
            foreach (var a in list)
            {
            Console.WriteLine($"{a.Title} -{a.Content}:{a.Author}");

            }

        }
    }
}
