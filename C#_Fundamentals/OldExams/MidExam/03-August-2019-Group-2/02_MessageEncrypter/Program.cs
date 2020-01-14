using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02_MessageEncrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"([@\*])(?<name>[A-Z][a-z]{2,})\1: \[(?<first>[A-Za-z]+)\]\|\[(?<second>[A-Za-z]+)\]\|\[(?<thirt>[A-Z-a-z]+)\]\|$");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (!regex.IsMatch(input))
                {
                    Console.WriteLine("Valid message not found!");
                    continue;
                }
                var match = regex.Match(input);
                string tag = match.Groups["name"].Value;
                string firstSymbol = match.Groups["first"].Value;
                string secondSymbol = match.Groups["second"].Value;
                string thirtSymbol = match.Groups["thirt"].Value;
                var text = firstSymbol.ToString();
                var secondText = secondSymbol.ToString();
                var thirtText = thirtSymbol.ToString();
                Console.WriteLine($"{tag}: {GetSum(text)} {GetSum(secondText)} {GetSum(thirtText)}");
            }
        }
        static int GetSum(string text) 
        {
            var sum = 0;
            foreach (var item in text)
            {
                sum += item;
            }
            return sum;
        }
    }
}

