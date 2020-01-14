using System;
using System.Linq;

namespace _04_4._LargestТхрееNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console
                 .ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .OrderByDescending(x => x)
                 .Take(3);
            foreach (var item in numbers)
            {

                Console.Write(item+" ");
            }
               

        }
    }
}
