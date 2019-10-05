using System;

namespace _03_
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityOfPeople = int.Parse(Console.ReadLine());
            double course = Math.Ceiling((double)(numberOfPeople) / capacityOfPeople);
            Console.WriteLine(course);

        }
    }
}
