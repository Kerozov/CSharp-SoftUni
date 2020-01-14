using System;
using System.Text.RegularExpressions;

namespace _03_MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Regex regex = new Regex(@"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b");
            MatchCollection result = regex.Matches(input);
            foreach (Match item in result)
            {
                Console.WriteLine($"Day: {item.Groups["day"].Value}, Month: {item.Groups["month"].Value}, Year: {item.Groups["year"].Value}");
            }
        }
    }
}
