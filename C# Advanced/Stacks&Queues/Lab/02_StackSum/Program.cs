using System;
using System.Collections.Generic;
using System.Linq;
namespace _02_StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var stack = new Stack<string>(input.Reverse());
            while (stack.Count!=1)
            {
                var firstNumber = int.Parse(stack.Pop());
                var function = stack.Pop();
                var secondNumber = int.Parse(stack.Pop());
                var tempResullt = 0;
                if (function=="+")
                {
                    tempResullt = firstNumber + secondNumber;
                }
                if (function == "-")
                {
                     tempResullt = firstNumber - secondNumber;
                }
                stack.Push(tempResullt.ToString());
            }
            Console.WriteLine(stack.Peek());
        }
    }
}
