using System;
using System.Text.RegularExpressions;

namespace _02_MessageDecrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"^([\$\%]?)(?<name>[A-Z][a-z]{2,})\1: \[(?<first>[0-9]+)\]\|\[(?<second>[0-9]+)\]\|\[(?<thirt>[0-9]+)\]\|$");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (!regex.IsMatch(input))
                {
                    Console.WriteLine("Valid message not found!");
                    continue;
                }
                var message = regex.Match(input);
                var first = int.Parse(message.Groups["first"].Value);
                var second = int.Parse(message.Groups["second"].Value);
                var thirt = int.Parse(message.Groups["thirt"].Value);
                var firstChar = (char)first;
                var secondChar = (char)second;
                var thirtChar = (char)thirt;
                var tag = message.Groups["name"].Value;
                Console.WriteLine($"{tag}: {firstChar}{secondChar}{ thirtChar}");
               
            }
        }
    }
}
