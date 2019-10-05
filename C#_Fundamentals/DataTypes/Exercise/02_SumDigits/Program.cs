using System;

namespace _02_
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string numberString = n.ToString();
            int sym = 0;
            int sym2= 0;
            for (int i = 0; i < numberString.Length; i++)
            {
                sym += n % 10;

                sym2 += sym;
                sym = 0;
                n /= 10;
            }
            Console.WriteLine(sym2);
        }
    }
} 
           
