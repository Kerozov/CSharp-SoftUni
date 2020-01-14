using System;
using System.Linq;

namespace _02_Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] book = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(Console.ReadLine());
            var newBook = new Articles(book[0], book[1], book[2]);
            for (int i = 0; i < n; i++)
            {

                string[] line = Console.ReadLine().Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                string command = line[0];
                if (command == "Edit")
                {
                    newBook.Edit(line[1]);
                }
                else if (command == "ChangeAuthor")
                {
                    newBook.ChangeAuthor(line[1]);
                }
                else if (command == "Rename")
                {
                    newBook.Rename(line[1]);
                }
            }
            Console.WriteLine($"{newBook.Titles} -{newBook.Content}:{newBook.Author}");
        }
    }
}
