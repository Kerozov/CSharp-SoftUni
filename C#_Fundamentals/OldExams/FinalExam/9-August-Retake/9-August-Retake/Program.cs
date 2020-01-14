using System;
using System.Linq;

namespace _9_August_Retake
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Sign up")
                {
                    break;
                }
                if (command.Contains("Case"))
                {
                    string[] tokkens = command.Split();
                    string caseCommand = tokkens[1];
                    if (caseCommand == "lower")
                    {
                        input = input.ToLower();
                    }
                    else
                    {
                        input = input.ToUpper();
                    }
                    Console.WriteLine(input);
                }
                else if (command.Contains("Reverse"))
                {
                    string[] tokkens = command.Split();
                    int startIndex = int.Parse(tokkens[1]);
                    int endIndex = int.Parse(tokkens[2]);
                    if (!(startIndex>=0&&endIndex<input.Length))
                    {
                        continue;
                    }
                    string substringInput = input.Substring(startIndex, endIndex - startIndex+1);
                    Console.WriteLine(new string(substringInput.Reverse().ToArray())); 
                }
                else if (command.Contains("Cut"))
                {
                    string[] tokkens = command.Split();
                    string substring = tokkens[1];
                    if (!input.Contains(substring))
                    {
                        Console.WriteLine($"The word {input} doesn't contain {substring}.");
                        continue;
                    }
                    int index = input.IndexOf(substring);

                    input = input.Remove(index,substring.Length);
                    Console.WriteLine(input);
                }
                else if (command.Contains("Replace"))
                {
                    string[] tokkens = command.Split();
                    char[] key = tokkens[1].ToCharArray();
                    input = input.Replace(key[0],'*');
                    Console.WriteLine(input);
                }
                else if (command.Contains("Check"))
                {
                    string[] tokkens = command.Split();
                    char[] validChar = tokkens[1].ToCharArray();
                    if (input.Contains(validChar[0]))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {validChar[0]}.");
                    }
                }
            }
        }
    }
}
