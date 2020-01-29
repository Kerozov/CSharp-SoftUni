using System;
using System.Collections.Generic;

namespace _06_ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            var parking = new HashSet<string>();
            while (true)
            {
                var command = Console.ReadLine().Split(", ");
                if (command[0]=="END")
                {
                    break;
                }

                if (command[0]=="IN")
                {
                    parking.Add(command[1]);
                }
                else
                {
                    parking.Remove(command[1]);
                }
            }

            if (parking.Count==0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
