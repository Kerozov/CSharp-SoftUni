using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            for (int i = 0; i < input[1]; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(input[2]))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count()==0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
