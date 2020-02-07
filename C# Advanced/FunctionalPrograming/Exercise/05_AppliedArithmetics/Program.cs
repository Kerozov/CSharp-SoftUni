using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();
            Action<List<double>> print = x => { Console.WriteLine(string.Join(" ", numbers)); };
            while (true)
            {
                var command = Console.ReadLine();
                if (command =="end")
                {
                    break;      
                }

                if (command=="add")
                {
                    numbers = numbers.Select(x => x + 1).ToList();
                }
               else if (command=="multiply")
                {
                   numbers = numbers.Select(x => x *2).ToList();
                }
                else if (command== "subtract")
                {
                    numbers = numbers.Select(x => x - 1).ToList();
                }
                else if (command == "print")
                {
                    print(numbers);
                }
            }
        }
    }
}
