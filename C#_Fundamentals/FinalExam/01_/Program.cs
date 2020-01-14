using System;
using System.Text;
namespace _01_
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (true)
            {
                string command = Console.ReadLine();
                if (command=="Finish")
                {
                    break;
                }

                if (command.Contains("Replace"))
                {
                    string[] tokkens = command.Split();
                    char[] currentChar = tokkens[1].ToCharArray(); 
                    char[] newChar = tokkens[2].ToCharArray();
                    input = input.Replace(currentChar[0], newChar[0]);
                    Console.WriteLine(input);
                }
                else if (command.Contains("Cut"))
                {
                    string[] tokkens = command.Split();
                    int startIndex = int.Parse(tokkens[1]);
                    int endIndex = int.Parse(tokkens[2]);
                    if (startIndex<0||endIndex>input.Length-1)
                    {
                        Console.WriteLine("Invalid indexes!");
                        continue;
                    }
                    input = input.Remove(startIndex, endIndex - startIndex + 1);
                    Console.WriteLine(input);
                }
                else if (command.Contains("Make"))
                {
                    string[] tokkens = command.Split();
                    if (tokkens[1]=="Upper")
                    {
                        input = input.ToUpper();
                        Console.WriteLine(input);
                    }
                    else
                    {
                        input = input.ToLower();
                        Console.WriteLine(input);
                    }
                }
                else if (command.Contains("Check"))
                {
                    string[] tokkens = command.Split();
                    string text = tokkens[1];
                    if (input.Contains(text))
                    {
                        Console.WriteLine($"Message contains {text}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {text}");
                    }
                }
                else if (command.Contains("Sum"))
                {
                    string[] tokkens = command.Split();
                    int startIndex = int.Parse(tokkens[1]);
                    int endIndex = int.Parse(tokkens[2]);
                    if (startIndex < 0 || endIndex > input.Length - 1)
                    {
                        Console.WriteLine("Invalid indexes!");
                        continue;
                    }
                    string substringInput = input.Substring(startIndex, endIndex - startIndex + 1); ;
                    var sum = 0;
                    for (int i = 0; i < substringInput.Length; i++)
                    {
                        sum += substringInput[i];
                    }
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
