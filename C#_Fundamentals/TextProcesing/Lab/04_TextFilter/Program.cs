using System;

namespace _04_TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            foreach (var item in key)
            {
                text = text.Replace(item, new string('*', item.Length));

            }
            Console.WriteLine(text);
        }
    }
}
