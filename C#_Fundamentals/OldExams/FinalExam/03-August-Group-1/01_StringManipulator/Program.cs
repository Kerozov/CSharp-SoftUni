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
                if (command == "End")
                {
                    break;
                }

                if (command.Contains("Translate"))
                {
                    var oldChar = command.Split()[1].ToCharArray();
                    var newChar = command.Split()[2].ToCharArray();
                    input = input.Replace(oldChar[0], newChar[0]);
                    Console.WriteLine(input);
                }
                else if (command.Contains("Includes"))
                {
                    var text = command.Split()[1];
                    Console.WriteLine(input.Contains(text));
                }
                else if (command.Contains("Start"))
                {
                    var text = command.Split()[1];
                    Console.WriteLine(input.StartsWith(text));
                }
                else if (command.Contains("Lowercase"))
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }
                else if (command.Contains("FindIndex"))
                {
                    var oldChar = command.Split()[1].ToCharArray();
                    int lastIndex =input.LastIndexOf(oldChar[0]);
                    Console.WriteLine(lastIndex);
                }   
                else if (command.Contains("Remove"))
                {
                    var tokkens = command.Split();
                    var startIndex = int.Parse(tokkens[1]);
                    var count = int.Parse(tokkens[2]);
                    input = input.Remove(startIndex,count);
                    Console.WriteLine(input);
                }
            }
        }
    }
}
