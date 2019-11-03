using System;
using System.Linq;
namespace Train
{
    class Program
    {
        private static int numberWagon;

        static void Main(string[] args)
        {
            int NumberWagon = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] personInWagons = new int[NumberWagon];
            for (int i = 0; i < NumberWagon; i++)
            {
                int person = int.Parse(Console.ReadLine());

                sum += person;
                personInWagons[i] = person;
                
            }
            foreach (var item in personInWagons)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
