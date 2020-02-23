using System;
using System.Security;
using System.Text;

namespace CarManufacturer
{
    class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public Car()
        {
            make = "VW";
            model = "Golf";
            year = 2025;
            fuelQuantity = 200;
            fuelConsumption = 10;
        }
        public Car(string Make, string Model, int Year)
        {
            this.make = Make;
            this.model = Model;
            this.year = Year;
        }
        public Car(string Make, string Model, int Year, double FuelQuantity, double FuelConsumption)
        : this(Make, Model, Year)
        {
            this.fuelConsumption = FuelConsumption;
            this.fuelQuantity = FuelQuantity;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelConsumption { get; set; }
        public double FuelQuantity { get; set; }

        public void Drive(double distance)
        {
            if (fuelQuantity - distance * fuelConsumption > 0)
            {
                fuelQuantity -= distance * fuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string CarInformation()
        {
            return $"Make: {this.make}\nModel: {this.model}\nYear: {this.year}\nFuel: {this.fuelQuantity:F2}L";
        }

    }
}