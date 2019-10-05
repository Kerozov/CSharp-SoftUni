using System;

namespace _07_WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        
       {
            int litersWater = int.Parse(Console.ReadLine());
            byte maxLiters = 255;
            int value = 0;
            int sumOfEnd = 0;
            int sum = 0;
            for (int i = 0; i < litersWater; i++)
            {
               
               value = int.Parse(Console.ReadLine());
                sum += value;
                if (maxLiters >= sum)
                {

                sumOfEnd += value;
                }
                else 
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= value;
                }
            }
            Console.WriteLine(sumOfEnd);
        }
    }
}
