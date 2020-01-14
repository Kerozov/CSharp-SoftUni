using System;
using System.Collections.Generic;

namespace _03_WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, List<string>>();
            for (int i = 0; i < number; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!dict.ContainsKey(word))
                {
                    dict[word] = new List<string>();
                }
                dict[word].Add(synonym);
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
            }
        }
    }
}
