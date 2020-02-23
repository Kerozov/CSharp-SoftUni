using System;
using System.Security;
using System.Text;
using CarEngineandTires;

namespace CarManufacturer
{
    class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tyre[] tyres;
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
            Make = make;
            Model = model;
            Year = year;
        }
        public Car(string Make, string Model, int Year, double FuelQuantity, double FuelConsumption)
            : this(Make, Model, Year)
        {
            FuelConsumption = fuelConsumption;
            FuelQuantity = fuelQuantity;
        }

        public Car(string Make, string Model, int Year, double FuelQuantity, double FuelConsumption, Engine Engine,
            Tyre[] tyre)
        : this(Make, Model, Year, FuelQuantity, FuelConsumption)
        {
            this.engine = Engine;
            Tyres = tyres;
        }
        public Tyre[] Tyres { get; set; }
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
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.fuelQuantity:F2}L";
        }

    }
}