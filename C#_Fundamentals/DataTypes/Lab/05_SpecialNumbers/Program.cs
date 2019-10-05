using System;

namespace _05_
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;
            int digits = 0;
            for (int i = 1; i <= number; i++)
            {
                sumOfDigits += i % 10;
                sumOfDigits += ( i / 10) ;

                digits += 1;
                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                   
                    Console.WriteLine($"{digits} -> True");
                }
                else
                {
                  
                    Console.WriteLine($"{digits} -> False");
                }
                sumOfDigits = 0;
            }
          
        }
    }
}
