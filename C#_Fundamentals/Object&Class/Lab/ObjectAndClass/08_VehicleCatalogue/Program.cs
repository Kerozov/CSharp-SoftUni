using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var trucks = new List<Trucks>();
            var cars = new List<Car>();
            while (line != "end")
            {
                string[] information = line.Split('/');
                string type = information[0];

                if (type == "Truck")
                {
                    var truck = new Trucks(information[1], information[2], information[3]);

                    trucks.Add(truck);
                }
                else if (type == "Car")
                {
                    var car = new Car(information[1], information[2], information[3]);
                    cars.Add(car);
                }
                line = Console.ReadLine();
            }

            cars = cars.OrderBy(x => x.brand).ToList();
            trucks = trucks.OrderBy(x => x.brand).ToList();
            if (cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in cars)
                {
                    Console.WriteLine($"{car.brand}: {car.model} - {car.horsePower}hp");
                }
            }
            if (trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in trucks)
                {
                    Console.WriteLine($"{truck.brand}: {truck.model} - {truck.weight}kg");
                }
            }
        }
    }
}
public class Trucks
{
    public Trucks(string Brand, string Model, string Weigth)
    {
        brand = Brand;
        model = Model;
        weight = Weigth;
    }
    public string brand { get; set; }
    public string model { get; set; }
    public string weight { get; set; }
}


public class Car
{
    public Car(string Brand, string Model, string Weigth)
    {
        brand = Brand;
        model = Model;
        horsePower = Weigth;
    }
    public string brand { get; set; }
    public string model { get; set; }
    public string horsePower { get; set; }
}





