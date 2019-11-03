using System;

namespace _01_EasterCozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());  
            double priceOneFlour=double.Parse(Console.ReadLine());
            double PricePackEggs = priceOneFlour * 0.75;
            double priceLiterMilk = priceOneFlour * 1.25/4;
            double totalPriceCozunac = priceLiterMilk + priceOneFlour + PricePackEggs;
            int reciveEggs = 0;
            int count = 0;
            while (!(budget<totalPriceCozunac))
            {
                budget -= totalPriceCozunac;
                reciveEggs += 3;
                count++;
                if (count%3==0)
                {
                    reciveEggs -=  count-2;
                }
            }
            Console.WriteLine($"You made {count} cozonacs! Now you have {reciveEggs} eggs and {budget:f2}BGN left."
);
        }
    }
}
