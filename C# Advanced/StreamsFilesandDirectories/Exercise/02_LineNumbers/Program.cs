using System;
using System.IO;
using System.Linq;

namespace _02_LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            var allLine = File.ReadLines(@".\text.txt").ToArray();
       
            
            for (int i = 0; i < allLine.Length; i++)
            {
                string currLine = allLine[i];
                var currCharCount = 0;
                var curPunctCount = 0;
                for (int j = 0; j < currLine.Length; j++)
                {
                    if (currLine[j] == '!' || currLine[j] == ','  || currLine[j] == '.' || currLine[j] == '?' ||
                        currLine[j] == '-' || currLine[j] == '\'')
                    {
                        curPunctCount++;
                    }
                    else if (currLine[j] == ' ')
                    {
                        continue;
                    }
                    else
                    {
                        currCharCount++;
                    }

                }
                currLine = $"Line {i + 1}:{currLine} ({currCharCount})" +
                           $"({curPunctCount})";
                
                allLine[i] = currLine;
            }
            File.WriteAllLines("../../../output.txt", allLine);
        }
    }
}
