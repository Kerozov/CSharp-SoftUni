using System;

namespace ClassBoxData
{
  public  class StartUp
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                var box = new Box(length,width,height);
                Console.WriteLine($"Surface Area - {box.CalculateSurface():f2}");
                Console.WriteLine($"Lateral Surface Area - {box.CalculateLateralSurface():f2}");
                Console.WriteLine($"Volume - {box.CalculateVolume():f2}");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
              
            }
          
        }
    }
}
