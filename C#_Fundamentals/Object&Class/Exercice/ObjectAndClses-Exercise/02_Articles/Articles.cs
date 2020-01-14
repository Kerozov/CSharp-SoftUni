using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Articles
{
    class Articles
    {
        public Articles(string titles,string content,string author)
        {
            Titles = titles;
            Content = content;
            Author = author;
        }
        public string Titles { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public  void Edit(string line)
        {
            Content = line;
        }
        public  void ChangeAuthor(string line)
        {
            Author = line;
        }
        public  void Rename(string line)
        {
            Titles = line;
        }

    }
}
