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

            //veriables
           BigInteger valueSnowball = 0;
            BigInteger maxValue = int.MinValue;
            int snowballQuality = 0;
            int snowballTime = 0;
            int snowballSnow = 0;


            //loop
            for (int i = 0; i < number; i++)
            {
                //input in the loop
                 snowballSnow = int.Parse(Console.ReadLine());
                 snowballTime = int.Parse(Console.ReadLine());
                 snowballQuality = int.Parse(Console.ReadLine());

                //manipulate
                valueSnowball = BigInteger.Pow(snowballSnow/ snowballTime, snowballQuality);
                if (maxValue< valueSnowball)
                {
                    maxValue = valueSnowball;
                }

            }

            //output
            Console.WriteLine($"{snowballSnow} : {snowballTime} = {valueSnowball} ({snowballQuality})");
        }
    }
}
