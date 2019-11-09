using System;
using System.Linq;

namespace _02_RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split()
                .ToList();
            var random = new Random();
            for (int i = 0; i < text.Count; i++)
            {
               int index =random.Next(0,text.Count);
                string randomElement = text[index];
                string element = text[i];
                text[index] = element;
                text[i] = randomElement;
            }
            foreach (var item in text)
            {
                Console.WriteLine(item);
            }
        }
    }
}
