using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Channels;

namespace _01_UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var names = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                var people = Console.ReadLine();
                names.Add(people);
            }

            
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
