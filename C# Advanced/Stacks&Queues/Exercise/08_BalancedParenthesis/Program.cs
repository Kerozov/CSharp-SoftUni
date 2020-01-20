using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();
            bool isBreak = false;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == '{' || input[i] == '[' || input[i] == '(' || input[i]==' ')
                {
                    stack.Push(input[i]);
                }
                else
                {
                    if (stack.Any())
                    {
                        char symbol = stack.Pop();
                        if ((symbol == '{' && input[i] == '}'))
                        {
                            isBreak = true;
                        }
                        else if ((symbol == '[' && input[i] == ']'))
                        {
                            isBreak = true;
                        }
                        else if ((symbol == '(' && input[i] == ')'))
                        {
                            isBreak = true;
                        }
                        else if ((symbol == ' ' && input[i] == ' '))
                        {
                            isBreak = true;
                        }
                    }
                    else
                    {
                        isBreak = false;
                    }
                }
            }

            if (input.Length==0)
            {
                Console.WriteLine("YES");
            }
            if (isBreak)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}

