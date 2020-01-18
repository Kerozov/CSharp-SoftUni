using System;
using System.Collections.Generic;
using System.Linq;

namespace _7_HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            Queue<string> peoples = new Queue<string>(input);
            var currentNum = 1;
            while (peoples.Count>1)
            {
                var currentName = peoples.Dequeue();
                if (n==currentNum)
                {
                    Console.WriteLine($"Removed {currentName}");
                    currentNum = 0;
                }
                else
                {
                    peoples.Enqueue(currentName);
                }
                currentNum++;
            }
            Console.WriteLine($"Last is {peoples.Peek()}");
        }
    }
}
 