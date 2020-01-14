using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
namespace _02_Race
{
    class Program
    {
        static void Main()
        {
            var regexName = new Regex(@"(?<name>[A-Za-z]+)");
            var regexDistance = new Regex(@"(?<distance>[0-9])");
            string[] input = Console.ReadLine().Split(", ");
            var dict = new Dictionary<string, int>();
            foreach (var name in input)
            {
                dict[name] = 0;
            }
            while (true)
            {
                string tokkens = Console.ReadLine();
                if (tokkens == "end of race")
                {
                    break;
                }
                var symbols = regexName.Matches(tokkens);
                var digits = regexDistance.Matches(tokkens);
                string name = string.Join("",symbols);
                if (dict.ContainsKey(name))
                {
                    foreach (Match digit in digits)
                    {
                        dict[name] += int.Parse(digit.Value);
                    }
                }
            }
              var result = dict.OrderByDescending(x => x.Value).ToArray();
            Console.WriteLine($"1st place: {result[0].Key}");
            Console.WriteLine($"2nd place: {result[1].Key}");
            Console.WriteLine($"3rd place: {result[2].Key}");
        }
    }
}
