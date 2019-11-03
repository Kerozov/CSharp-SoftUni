using System;
using System.Collections.Generic;
using System.Linq;
namespace _07_AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> list = Console.ReadLine()
                .Split("|")
                .ToList();
            List<string> newList = new List<string>();
            list.Reverse();

            for (int i = 0; i < list.Count; i++)
            {
                string curentNumber = list[i];
                List<string> curent  = curentNumber.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                newList.AddRange(curent);
             
            }
            Console.WriteLine(string.Join(" ",newList));
        }
    }
}
