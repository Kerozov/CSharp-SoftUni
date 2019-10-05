using System;

namespace poundToDolars
{
    class Program
    {
        static void Main(string[] args)
        {
            double pound = double.Parse(Console.ReadLine());

            double dolars = pound * 1.31;
            Console.WriteLine($"{dolars:f3}");
        }
    }
}
