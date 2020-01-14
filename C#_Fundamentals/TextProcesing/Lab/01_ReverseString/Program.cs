using System;
using System.Collections.Generic;

namespace _01_ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var reversedWord = "";
            while (true)
            {
                if (input == "end")
                {
                    break;
                }
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversedWord += input[i];
                }
                Console.WriteLine($"{input} = {reversedWord}");
                reversedWord = string.Empty;
                input = Console.ReadLine();
            }
        }
    }
}
