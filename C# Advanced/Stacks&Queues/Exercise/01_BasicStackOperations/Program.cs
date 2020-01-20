using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            for (int i = 0; i < input[1]; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(input[2]))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count() == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }


        }
    }
}
