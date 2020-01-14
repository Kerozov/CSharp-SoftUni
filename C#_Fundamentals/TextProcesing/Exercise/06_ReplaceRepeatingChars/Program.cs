using System;
using System.Text;

namespace _06_ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var result = new StringBuilder();
            for (int i = 0; i < input.Length-1; i++)
            {
                char next = input[i+1];
                if (input[i]==next)
                {
                    continue;
                }
                result.Append(input[i]);
            }
            result.Append(input[input.Length-1]);
            Console.WriteLine(result); ;
        }
    }
}
