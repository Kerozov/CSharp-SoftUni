using System;

namespace _06_CalculateRectangleArea
{
    class Program
    {
        static int Area(int width,int heigth)
        {
            return width * heigth;
        }
        static void Main(string[] args)
        {
            int width =  int.Parse(Console.ReadLine());
            int heigth =  int.Parse(Console.ReadLine());
            Console.WriteLine(Area(width, heigth));
        }
    }
}
