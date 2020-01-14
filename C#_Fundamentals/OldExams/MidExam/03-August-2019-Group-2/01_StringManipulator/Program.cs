using System;

namespace _01_StringManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (true)
            {
                string command = Console.ReadLine();
                if (command=="Done")
                {
                    break;
                }
                if (command.Contains("Change"))
                {
                    string[] tokkens = command.Split();
                    var oldChar = tokkens[1];
                    var newChar = tokkens[2];
                    input = input.Replace(oldChar, newChar);
                    Console.WriteLine(input);
                }
                else if (command.Contains("Includes"))
                {
                    string[] tokkens = command.Split();
                    Console.WriteLine(input.Contains(tokkens[1]));
                }
                else if (command.Contains("End"))
                {
                    string[] tokkens = command.Split();
                    Console.WriteLine(input.EndsWith(tokkens[1]));
                }
                else if (command.Contains("Uppercase"))
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }
                else if (command.Contains("FindIndex"))
                {
                    string[] tokkens = command.Split();
                    var index = input.IndexOf(tokkens[1]);
                    Console.WriteLine(index);
                }
                else if (command.Contains("Cut"))
                {
                    string[] tokkens = command.Split();
                    var startIndex = int.Parse(tokkens[1]);
                    var length = int.Parse(tokkens[2]);
                    input = input.Substring(startIndex, length);
                    Console.WriteLine(input);
                }
            }
        }
    }
}
