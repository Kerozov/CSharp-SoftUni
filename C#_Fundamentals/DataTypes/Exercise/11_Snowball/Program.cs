using System;
using System.Numerics;
namespace _11_snowball
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int number = int.Parse(Console.ReadLine());

            //variables
           BigInteger valueSnowball = 0;
            BigInteger maxValue = int.MinValue;
            int snowballQualityMax = 0;
            int snowballTimeMax = 0;
            int snowballSnowMax = 0;


            //loop
            for (int i = 0; i < number; i++)
            {
                //input in the loop
                 int snowballSnow = int.Parse(Console.ReadLine());
                 int snowballTime = int.Parse(Console.ReadLine());
                 int snowballQuality = int.Parse(Console.ReadLine());

                //manipulate
                valueSnowball = BigInteger.Pow(snowballSnow/ snowballTime, snowballQuality);
                if (maxValue< valueSnowball)
                {
                    maxValue = valueSnowball;
                    snowballQualityMax = snowballQuality;
                    snowballTimeMax = snowballTime;
                    snowballSnowMax = snowballSnow;
                }

            }

            //output
            Console.WriteLine($"{snowballSnowMax} : {snowballTimeMax} = {maxValue} ({snowballQualityMax})");
        }
    }
}
