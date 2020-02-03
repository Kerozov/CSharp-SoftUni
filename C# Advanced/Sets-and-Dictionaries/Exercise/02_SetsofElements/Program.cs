using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_SetsofElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var firstHash = new HashSet<int>();
            var secondHash = new HashSet<int>();
            
            for (int i = 0; i < length[0]; i++)
            {
                var input = int.Parse(Console.ReadLine());
                firstHash.Add(input);
            }

            for (int i = 0; i < length[1]; i++)
            {
                var input = int.Parse(Console.ReadLine());
                secondHash.Add(input);
            }

            foreach (var num in firstHash)
            {
                foreach (var n in secondHash)
                {
                    if (num==n)
                    {
                        Console.Write(n+" ");
                    }
                }
            }
                 
            
        }
    }
}
