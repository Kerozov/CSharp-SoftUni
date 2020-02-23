using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01_DatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var males = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var females = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var matches = 0;
            var count = males.Count;

            var maleStack = new Stack<int>(males);
            var femaleQueue = new Queue<int>(females);


            while (maleStack.Count != 0 && femaleQueue.Count != 0)
            {
                var male = maleStack.Peek();
                var female = femaleQueue.Peek();
                if (male <= 0 || male % 25 == 0)
                {
                    maleStack.Pop();
                    continue;
                }

                if (female <= 0 || female % 25 == 0)
                {
                    femaleQueue.Dequeue();
                    continue;
                }

                if (male==female)
                {
                    femaleQueue.Dequeue();
                    maleStack.Pop();
                    matches++;
                }
                else
                {
                    femaleQueue.Dequeue();
                    var value = maleStack.Pop();
                    value -= 2;
                    maleStack.Push(value);
                }
            }

            Console.WriteLine($"Matches: {matches}");
            if (maleStack.Count == 0)
                Console.WriteLine("Males left: none");
            else
            {
                Console.WriteLine($"Males left: {string.Join(", ", maleStack)}");
            }
            if (femaleQueue.Count == 0)
            {
                Console.WriteLine("Females left: none");
            }
            else
            {
                Console.WriteLine($"Females left: {string.Join(", ", femaleQueue)}");
            }
        }
    }
}
