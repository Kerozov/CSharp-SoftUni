using System;
using System.Text;

namespace _02_RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            var sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];
                for (int k = 0; k < word.Length; k++)
                {
                    sb.Append(word);
                }
            }
            Console.WriteLine(sb);
        }
    }
}
