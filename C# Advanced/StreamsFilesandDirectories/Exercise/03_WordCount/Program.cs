using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03_WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllLines(@".\text.txt");
            var syrch = File.ReadAllLines(@".\words.txt");
           

            var countWords = new Dictionary<string, int>();
            foreach (var line in text)
            {
                string[] words = line.Split(new []{' ','-',',','.'});
                for(int i =0;i<words.Length-1;i++)
                {

                    foreach (var word in syrch)
                    {
                        if (word == words[i].ToLower())
                        {
                            if (!countWords.ContainsKey(words[i].ToLower()))
                            {
                                countWords[words[i].ToLower()] = 0;
                            }

                            countWords[words[i].ToLower()]++;

                        }
                    }
                }
            }

            var actualResults = new string[syrch.Length];
            var expectedResult = new string[syrch.Length];
            int count = 0;
            foreach (var word in countWords)
            {
                string line = $"{word.Key} - {word.Value}";
                actualResults[count] = line;
                count++;
            }

            count = 0;
            foreach (var word in countWords.OrderByDescending(x => x.Value))
            {
                string line = $"{word.Key} - {word.Value}";
                expectedResult[count] = line;
                count++;
            }

            File.WriteAllLines(@"..\..\..\actualResults.txt", actualResults);
            File.WriteAllLines(@"..\..\..\expectedResult.txt", expectedResult);
        }
    }
}
