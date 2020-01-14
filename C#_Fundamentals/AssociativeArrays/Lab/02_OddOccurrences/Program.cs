using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            var dict = new Dictionary<string, int>();
            foreach (var word in words)
            {
                string wordToLower = word.ToLower();
                if (!dict.ContainsKey(wordToLower))
                {
                    dict.Add(wordToLower, 0);
                }
                dict[wordToLower]++;
            }
            foreach (var item in dict)
            {
                if (item.Value%2==1)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}
