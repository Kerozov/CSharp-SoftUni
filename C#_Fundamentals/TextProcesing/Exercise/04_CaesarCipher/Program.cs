using System;
using System.Text;

namespace _04_CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var text = new StringBuilder();
            foreach (var c in input)
            {

                text.Append((char)(c + 3));
            }
            Console.WriteLine(text);
        }
       
    }
}

