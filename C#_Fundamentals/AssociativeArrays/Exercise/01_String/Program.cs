using System;
using System.Collections.Generic;
namespace _01_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            var dict = new Dictionary<char, int>();
            foreach (string word in input)
            {
                for (int k = 0; k < word.Length; k++)
                {
                    if (!dict.ContainsKey(word[k]))
                    {
                        dict.Add(word[k], 0);
                    }
                    dict[word[k]]++;
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
