using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;


namespace _06_ReverseandExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var devisionNumber = int.Parse(Console.ReadLine());
            var devisible = new List<int>();
            Func<int, int, bool> devisibleFunc = (x, y) => x % y == 0;
            foreach (var number in input)
            {
                if (!devisibleFunc(number,devisionNumber))
                {
                    devisible.Add(number);
                }
            }

            devisible.Reverse();
            devisible.ForEach(x=>Console.Write(x+" "));
        }
    }
}
