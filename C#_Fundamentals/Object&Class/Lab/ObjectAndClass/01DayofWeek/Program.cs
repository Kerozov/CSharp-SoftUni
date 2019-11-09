using System;
using System.Globalization;

namespace _01DayofWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.ParseExact(
                Console.ReadLine(),
                "dd-MM-yyyy",
                CultureInfo.InvariantCulture) ;
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
