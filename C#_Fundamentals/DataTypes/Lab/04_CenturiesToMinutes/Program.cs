using System;

namespace _04_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int years =n* 100;
            int days = (int)(years * 365.2422);
            int hours = 24*days;
            int minutes = 60*hours;
           
            Console.WriteLine($"{n} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes ");
        }
    }
}
