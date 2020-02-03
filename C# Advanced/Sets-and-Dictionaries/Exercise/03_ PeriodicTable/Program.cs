using System;
using System.Collections.Generic;
using System.Linq;

namespace _03__PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var elements = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                foreach (var element in input)
                {
                    elements.Add(element);
                }
            }

            elements = elements.OrderBy(x => x).ToHashSet();
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
