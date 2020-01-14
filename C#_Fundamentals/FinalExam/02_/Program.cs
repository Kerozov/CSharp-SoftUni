using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02_
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"!(?<tag>[A-Z][a-z]{2,})!:\[(?<letters>[A-Za-z]{8,})\]");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (!regex.IsMatch(input))
                {
                    Console.WriteLine("The message is invalid");
                    continue;
                }
                var message = regex.Match(input);
                var tag = message.Groups["tag"].Value.ToString();
                var letters = message.Groups["letters"].Value.ToString();
                var result = new List<int>();
                for (int k = 0; k < letters.Length; k++)
                {
                   result.Add((int)letters[k]);
                }
                Console.WriteLine($"{tag}: {string.Join(" ",result)}");
            }
        }
    }
}
