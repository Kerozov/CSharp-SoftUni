using System;

namespace _08_contactName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string name2 = Console.ReadLine();
            string delimiter = Console.ReadLine();
            Console.WriteLine($"{name}{delimiter}{name2}");
        }
    }
}
