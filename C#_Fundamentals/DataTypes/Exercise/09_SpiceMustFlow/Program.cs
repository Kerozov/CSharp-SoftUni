using System;

namespace _09_SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int day = 0;

            int amount = 0;
            while (startingYield>=100)
            {
                day += 1;
                    amount += startingYield;
               
                    startingYield -= 10;
                
                if (amount-26<0)
                {
                    amount =  0;

                }
                else
                {
                    amount -= 26;
                }
            }
           

            if (amount - 26< 0)
            {
                amount = 0;
            

            }
            else
            {

                amount -= 26;
            }
           
            Console.WriteLine(day);
            Console.WriteLine(amount);
        }
    }
}
