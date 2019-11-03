using System;
using System.Collections.Generic;
using System.Linq;

namespace _04__ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string line = Console.ReadLine();
            while (line != "End")
            {
                string[] lines = line.Split();
                string command = lines[0];
                if (command == "Add")
                {
                    int number = int.Parse(lines[1]);
                    numbers.Add(number);
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(lines[1]);
                    int index = int.Parse(lines[2]);
                    if (index<0||index>numbers.Count-1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                    numbers.Insert(index, number);
                    }
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(lines[1]);
                    if (index < 0 || index > numbers.Count - 1)
                    {
                        Console.WriteLine("Invalid index");                    }
                    else
                    {
                    numbers.RemoveAt(index);
                    }
                }
                else if (command == "Shift")
                {
                    int count = int.Parse(lines[2]);
                    string commandTwo = lines[1];
                    if (commandTwo=="left")
                    {
                    ShiftLeft(numbers, count);
                    }
                     if(commandTwo == "right")
                    {
                     ShiftRigth(numbers, count);
                    }
                }
                
                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        static void ShiftLeft(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int firstNumber = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(firstNumber);
            }
        }
        static void ShiftRigth(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int lastNumber = numbers[numbers.Count-1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastNumber);
            }
        }
    }
}
