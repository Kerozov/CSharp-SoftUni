using System;
using System.Linq;

namespace _01_SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            
             var IO =    Console.ReadLine().Split(", ").Select(int.Parse).Where(x => x % 2 == 0).OrderBy(x => x).ToList()
                   ;
             Console.WriteLine(string.Join(", ", IO));
        }
    }
}
