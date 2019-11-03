using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> parts = Console.ReadLine()
                 .Split('|')
                 .ToList();
            string line = Console.ReadLine();
            while (line != "Done")
            {
                string[] lines = line.Split();
                string command = lines[0];
                if (command == "Move")
                {

                    string commandTwo = lines[1];
                    if (commandTwo == "Left")
                    {
                        int index = int.Parse(lines[2]);
                        if (index > 0 && index < parts.Count)
                        {
                            string current = parts[index];
                            parts[index] = parts[index - 1];
                            parts[index - 1] = current;

                        }
                        
                    }
                    else if (commandTwo == "Right")
                    {
                        int index = int.Parse(lines[2]);
                        
                            if (index >= 0 && index < parts.Count-1)
                            {
                                string current = parts[index];
                                parts[index] = parts[index + 1];
                                parts[index + 1] = current;

                            }
                            
                        
                    }
                }
                else if (command== "Check")
                {
                    string commandTwo = lines[1];
                    if (commandTwo== "Even")
                    {
                        List<string> even = new List<string>();
                        for (int i = 0; i < parts.Count; i++)
                        {
                            if (i%2==0)
                            {
                                even.Add(parts[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ",even));
                    }
                    else if (commandTwo=="Odd")
                    {
                        List<string> odd = new List<string>();
                        for (int i = 0; i < parts.Count; i++)
                        {
                            if (i % 2 == 1)
                            {
                                odd.Add(parts[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", odd));
                    }
                }

                line = Console.ReadLine();
            }
            string weaphon = "";
            foreach (var item in parts)
            {
                weaphon += item;
            }
            Console.WriteLine($"You crafted {weaphon}!");
        }
    }
}
