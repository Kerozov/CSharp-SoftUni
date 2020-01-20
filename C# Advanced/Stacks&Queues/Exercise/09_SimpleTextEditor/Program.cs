using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace _09_SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var text = string.Empty;
            var previous = new Stack<string>();
            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split().ToArray();
                if (command[0]=="1")
                {
                    previous.Push(text);
                    text += command[1];
                   
                }
                else if (command[0]=="2")
                {
                    previous.Push(text);
                    int count = int.Parse(command[1]);
                    text = text.Substring(0,text.Length - count);
                }
                else if (command[0]=="3")
                {
                    int index = int.Parse(command[1]);
                    Console.WriteLine(text[index-1]);

                }
                else if (command[0]=="4")
                {
                    text = previous.Pop();
                }
               
            }

        }
    }
}
