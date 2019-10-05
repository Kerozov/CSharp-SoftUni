using System;

namespace _12_RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Console.Write("Length: ");
            decimal length =decimal.Parse(Console.ReadLine());


            Console.Write("Width: ");
            decimal width = decimal.Parse(Console.ReadLine());


            Console.Write("Height: ");
            decimal heigth = decimal.Parse(Console.ReadLine());


            decimal pyramidVolume = 0;
           
            pyramidVolume = ((length * width) * heigth) /3;
            Console.WriteLine($"Pyramid Volume: {pyramidVolume:f2}");

        }
    }
}
