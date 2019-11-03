using System;

namespace _01_BlackFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double exeptedPlunder = double.Parse(Console.ReadLine());
            double allPlunder = 0;
            for (int i = 1; i <= days; i++)
            {
                allPlunder += dailyPlunder;
                if (i%3==0)
                {
                    allPlunder += dailyPlunder * 0.50;
                }
                if (i % 5 == 0)
                {
                    allPlunder -= allPlunder * 0.30;
                }
               
            }
            if (allPlunder>=exeptedPlunder)
            {
                Console.WriteLine($"Ahoy! {allPlunder:f2} plunder gained.");
            }
            else
            {
                double percentageLeft = allPlunder / exeptedPlunder * 100;
                ;
                Console.WriteLine($"Collected only {percentageLeft:f2}% of the plunder.");
            }
        }
    }
}
