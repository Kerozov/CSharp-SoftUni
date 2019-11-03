using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int numberTwo = int.Parse(Console.ReadLine());
            double result = 0;
            if (operation=="/")
            {
               result =  numberOne / numberTwo;
            }
            else if (operation=="*")
            {
                result = numberOne * numberTwo;
            }
            else if(operation == "+")
            {
                result = numberOne + numberTwo;
            }
            else
            {
                result = numberOne - numberTwo;
            }
            Console.WriteLine(Math.Round(result));
        }
    }
}
