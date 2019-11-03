using System;
using System.Collections.Generic;

namespace _03_.House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPerson = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            for (int i = 0; i < numberPerson; i++)
            {
                string fun = Console.ReadLine();
                string[] function = fun.Split(" ");
                if (function[2]=="going!")
                {
                    if (names.Contains(function[0]))
                    {
                        Console.WriteLine($"{function[0]} is already in the list!");
                    }
                    else
                    {
                    names.Add(function[0]);

                    }
                }
                else
                {
                    if(names.Contains(function[0]))
                    {
                    names.Remove(function[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{function[0]} is not in the list!");
                    }
                }
            }

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
