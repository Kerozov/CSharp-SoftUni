using System;
using System.Text.RegularExpressions;

namespace _01_MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var regex = new Regex(@"\b[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+\b");
           var result = regex.Matches(input);
            foreach (Match item in result)
            {
                Console.Write($"{item.Value} ");
            }
        }
    }
}
