using System;
using System.Linq;
using System.Threading.Channels;

namespace _02_KnightsofHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(x=>$"Sir {x}")
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
