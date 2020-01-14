using System;
using System.Text.RegularExpressions;

namespace _03_SoftUniBarIncome
{
    class Program
    {
        static void Main()
        {
            var regexName = new Regex(@"%(?<name>[A-Z][a-z]+)%");
            var regexProduct = new Regex(@"<(?<product>\w+)>");
            var regexCount = new Regex(@"\|(?<count>\d+)\|");
            var regexPrice = new Regex(@"(?<price>[0-9.]+)\$");
            var totalSum = 0.0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of shift")
                {
                    break;
                }
                var validName = regexName.IsMatch(input);
                var validProduct = regexProduct.IsMatch(input);
                var validCount = regexCount.IsMatch(input);
                var validPrice = regexPrice.IsMatch(input);
                if (validName && validProduct && validCount && validPrice)
                {
                    var customerNameMatch = regexName.Match(input);
                    var productMatch = regexProduct.Match(input);
                    var countMatch = regexCount.Match(input);
                    var priceMatch = regexPrice.Match(input);
                    var customerName =customerNameMatch.Groups["name"].Value;
                    var product =productMatch.Groups["product"].Value;
                    var count = int.Parse(countMatch.Groups["count"].Value);
                    var price = double.Parse(priceMatch.Groups["price"].Value);
                    var sum = price* count;
                    totalSum += sum;
                    Console.WriteLine($"{customerName}: { product} - { sum:f2}");
                }
            }
                Console.WriteLine($"Total income: {totalSum:f2}");
        }
    }
}
