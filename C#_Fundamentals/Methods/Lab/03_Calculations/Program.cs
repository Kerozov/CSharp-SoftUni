using System;

namespace _03_Calculations
{
    class Program
    {
        static double Sum(double numberOne,double numberTwo)
        {
            return numberOne + numberTwo;
        }
        static double MultiplyNumber(double numberOne, double numberTwo)
        {
            return numberOne * numberTwo;
        }
        static double subtractNumber(double numberOne, double numberTwo)
        {
            return numberOne - numberTwo;
        }
        static void Main(string[] args)
        {
            string function = Console.ReadLine();
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            double result = 0;
            if (function=="add")
            {
               result= Sum(numberOne, numberTwo);
            }
            else if (function== "multiply")
            {
               result =  MultiplyNumber(numberOne, numberTwo);
            }
            else if (function == "subtract")
            {
               result= subtractNumber(numberOne, numberTwo);
            }
            else
            {
                 result = numberOne / numberTwo;
            }

                Console.WriteLine(result);

        }
    }
}
