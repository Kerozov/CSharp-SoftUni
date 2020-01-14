using System;
using System.Text.RegularExpressions;

namespace _02_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"(.+)>(?<digits>[0-9]{3})\|(?<lower>[a-z]{3})\|(?<upper>[A-Z]{3})\|(?<symbol>[^<>]{3})<\1");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string password = Console.ReadLine();
                if (!regex.IsMatch(password))
                {
                    Console.WriteLine("Try another password!");
                    continue;
                }
                var matchPassword = regex.Match(password);
                var digits = matchPassword.Groups["digits"].Value.ToString();
                var lower = matchPassword.Groups["lower"].Value.ToString();
                var upper = matchPassword.Groups["upper"].Value.ToString();
                var symbol = matchPassword.Groups["symbol"].Value.ToString();
                var validPassword = digits + lower + upper + symbol;
                Console.WriteLine($"Password: {validPassword}");
            }
        }
    }
}
