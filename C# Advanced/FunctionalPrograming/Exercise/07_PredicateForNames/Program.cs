using System;
using System.Linq;

namespace _07_PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var names = Console.ReadLine()
                .Split()
                .ToList();
            Func<string, bool> filter = x => x.Length <= length;
            foreach (var name in names)
            {
                if (filter(name))
                {
                    Console.WriteLine(name);
                }
            }
           
        }
    }
}
