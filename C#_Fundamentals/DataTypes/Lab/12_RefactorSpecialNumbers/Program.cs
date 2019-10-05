using System;

namespace _12_RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int symOfDigits = 0;
            int digits = 0;
            bool istrue = false;
            for (int i = 1; i <= number; i++)
            {
                digits = i;
                while (i > 0)
                {
                    symOfDigits += i % 10;
                    i = i / 10;
                }
                istrue = (symOfDigits == 5) || (symOfDigits == 7) || (symOfDigits == 11);
                Console.WriteLine("{0} -> {1}", digits, istrue);
                symOfDigits = 0;
                i = digits;
            }
        }
    }
}
