using System;
using System.Collections.Generic;
using System.Linq;
namespace _03_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namesFrogs = Console.ReadLine()
                .Split(' ')
                .ToList();
            string line = Console.ReadLine();
            while (line != "Print Normal" && line != "Print Reversed")
            {
                string[] command = line.Split();
                if (command[0] == "Join")
                {
                    namesFrogs.Add(command[1]);
                }

                else if (command[0] == "Jump")
                {
                    string name = command[1];
                    int index = int.Parse(command[2]);
                    if (index < namesFrogs.Count && index >= 0)
                    {
                        namesFrogs.Insert(index, name);
                    }
                }
                else if (command[0] == "Dive")
                {
                    int index = int.Parse(command[1]);
                    if (index < namesFrogs.Count && index >= 0)
                    {
                        namesFrogs.RemoveAt(index);
                    }
                }
                else if (command[0] == "First")
                {
                    int count = int.Parse(command[1]);

                    PrintFirst(namesFrogs, count);
                }
                else if (command[0] == "Last")
                {
                    int count = int.Parse(command[1]);
                    PrintEnd(namesFrogs, count);
                }

                line = Console.ReadLine();
            }
            string[] command1 = line.Split();
            if (command1[1] == "Normal")
            {
                Console.Write("Frogs: ");
                Console.WriteLine(string.Join(" ", namesFrogs));
            }
            else if (command1[1] == "Reversed")
            {
                namesFrogs.Reverse();
                Console.Write("Frogs: ");
                Console.WriteLine(string.Join(" ", namesFrogs));

            }
        }
        static void PrintEnd(List<string> namesFrogs, int count)
        {
            for (int i = 0; i < namesFrogs.Count; i++)
            {
                if (namesFrogs.Count - count <= i && namesFrogs.Count > 0)
                {
                    Console.Write(namesFrogs[i] + " ");
                }
            }
            Console.WriteLine();
        }
        static void PrintFirst(List<string> namesFrogs, int count)
        {
            for (int i = 0; i < count; i++)
            {
                if (namesFrogs.Count > i)
                {
                    Console.Write(namesFrogs[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

