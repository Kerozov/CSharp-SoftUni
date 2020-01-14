using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01_
{
    class Program
    {
        static void Main()
        {
            var regex = new Regex(@">>(?<name>[A-Za-z]+)<<(?<price>[0-9.]+)!(?<qantity>\d+)");
            var products = new List<string>();
            double allPrice = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Purchase")
                {
                    break;
                }
                var isValid = regex.IsMatch(input);
                if (isValid == false)
                {
                    continue;
                }
                var tokkens = regex.Match(input);
                double price = double.Parse(tokkens.Groups["price"].Value);
                int qantity = int.Parse(tokkens.Groups["qantity"].Value);
                products.Add(tokkens.Groups["name"].Value);
                allPrice += price * qantity;
            }
            Console.WriteLine("Bought furniture:");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine($"Total money spend: {allPrice:f2}");
        }
    }
}
