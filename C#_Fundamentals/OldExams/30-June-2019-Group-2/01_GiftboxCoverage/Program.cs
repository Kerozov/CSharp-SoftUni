using System;

namespace _01_
{
    class Program
    {
        static void Main(string[] args)
        {
            double size = double.Parse(Console.ReadLine());
            int countPaper = int.Parse(Console.ReadLine());
            double areaOneSheet = double.Parse(Console.ReadLine());
            double areaBox = size * size * 6;
            double areaSheets = 0;
            for (int i = 1; i <= countPaper; i++)
            {
                if (i % 3 == 0)
                {

                   
                    areaSheets += areaOneSheet * 0.25;

                }
                else
                {
                    areaSheets+= areaOneSheet ;

                }
            }
            double percentage = areaSheets /areaBox * 100;
            Console.WriteLine($"You can cover {percentage:f2}% of the box.");

        }
    }
}
