using System;
using System.Dynamic;
using System.Linq;
using System.Threading.Channels;

namespace _04_AddVAT
{
    class startUp
    {
        static void Main(string[] args)
        {
             Console.ReadLine()
                .Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x=>x*1.2)
                .Select(x=>x.ToString("F2"))
                .ToList()
                .ForEach(Console.WriteLine);
                 
        }
    }
}
