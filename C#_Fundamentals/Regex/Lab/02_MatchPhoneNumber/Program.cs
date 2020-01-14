using System;
using System.Text.RegularExpressions;

namespace _02_MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var regex = new Regex(@"(\+359(-| )2\2[0-9]{3}\2[0-9]{4})\b");
            var result = regex.Matches(input);
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
