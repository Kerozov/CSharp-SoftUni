using System;

namespace _03_ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\');
            string[] info = input[input.Length - 1].Split('.');
            string fileName = info[0];
            string extension = info[1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
