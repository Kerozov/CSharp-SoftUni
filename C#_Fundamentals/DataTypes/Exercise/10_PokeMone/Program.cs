using System;

namespace _10_pokeMone
{
    class Program
    {
        static void Main(string[] args)
        {
           


            {
                //input
                int pokePowerN = int.Parse(Console.ReadLine());
                int distanceM = int.Parse(Console.ReadLine());
                int exhaustionFactor = int.Parse(Console.ReadLine());

                //variables
                int count = 0;
                double powerInInput = pokePowerN*0.5;

                //loops
                while (distanceM <= pokePowerN)
                {
                    count++;
                    pokePowerN -= distanceM;
                    if (pokePowerN == powerInInput && exhaustionFactor != 0)
                    {

                        pokePowerN /= exhaustionFactor;

                    }

                    //input
                }
                    Console.WriteLine(pokePowerN);
                    Console.WriteLine(count);
            }
        }
    }
}
