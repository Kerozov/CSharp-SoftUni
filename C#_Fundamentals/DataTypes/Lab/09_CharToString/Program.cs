using System;

namespace _10_charToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            string text =a.ToString()+ b.ToString()+ c.ToString();
            Console.WriteLine(text);

        }
    }
}
