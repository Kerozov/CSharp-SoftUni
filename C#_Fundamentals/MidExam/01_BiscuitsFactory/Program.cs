using System;

namespace _01_
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountBiscuit = int.Parse(Console.ReadLine());
            int countWorkerers = int.Parse(Console.ReadLine());
            int am0untBiscuitMounth = int.Parse(Console.ReadLine());
            int workersProduction = amountBiscuit * countWorkerers;
            double allBiscuit = 0;
            for (int i = 1; i <= 30; i++)
            {
                
                if (i % 3 == 0 )
                {
                    allBiscuit += workersProduction * 0.75;
                }
                else
                {
                    allBiscuit += workersProduction;

                }
                allBiscuit = Math.Floor(allBiscuit);
            }
            double diff = allBiscuit - am0untBiscuitMounth;
            double percentage = diff / am0untBiscuitMounth * 100;
            Console.WriteLine($"You have produced {allBiscuit} biscuits for the past month.");
            if (diff>0)
            {
                Console.WriteLine($"You produce {percentage:f2} percent more biscuits.");
            }
            else
            {
                percentage *= -1;
                Console.WriteLine($"You produce {percentage:f2} percent less biscuits.");
            }
        }
       
    }
}
