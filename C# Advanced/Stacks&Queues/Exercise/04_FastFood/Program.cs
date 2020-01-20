using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity;
            quantity = int.Parse(Console.ReadLine());
            var orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var left = new Queue<int>(orders);
            Console.WriteLine(orders.Max());
            while (true)
            {
                if (quantity==0|| left.Count() == 0|| left.Peek() > quantity)
                {
                    break;
                }
                    int current = left.Dequeue();
                    quantity -= current;
                
            }
            if (left.Count() == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                
                Console.WriteLine($"Orders left: {string.Join(' ', left)}");
            }
        }
    }
}
