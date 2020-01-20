using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_MaximumandMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split();
                if (int.Parse(command[0]) == 1)
                {
                    stack.Push(int.Parse(command[1]));
                }
                else if (int.Parse(command[0]) == 2)
                {
                    stack.Pop();
                }
                else if (int.Parse(command[0]) == 3)
                {
                    if (stack.Count()==0)
                    {
                        continue;
                    }
                    Console.WriteLine(stack.Max());
                }
                else if (int.Parse(command[0]) == 4)
                {
                    if (stack.Count() == 0)
                    {
                        continue;
                    }
                    Console.WriteLine(stack.Min());
                }
            }
            Console.WriteLine(string.Join(", ",stack)) ;
        }
    }
}
