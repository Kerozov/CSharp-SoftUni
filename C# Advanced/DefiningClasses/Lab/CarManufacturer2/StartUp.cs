﻿using System;

namespace CarManufacturer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());
            var car = new Car();
            var secondCar = new Car(make,model,year);
            var thirtCar = new Car(make,model,year,fuelQuantity,fuelConsumption);
            Console.WriteLine(secondCar.FuelQuantity);
        }
    }
}
