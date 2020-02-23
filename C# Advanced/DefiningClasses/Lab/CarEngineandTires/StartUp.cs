using System;
using CarManufacturer;

namespace CarEngineandTires
{
    class StartUp
    {
        static void Main(string[] args)
        {
           var tyres = new Tyre[4]
           {
               new Tyre(1,2.5), 
               new Tyre(1,2.1), 
               new Tyre(2,0.5), 
               new Tyre(2,2.3) 
           };
           var engine = new Engine(560,6300);
           var car = new Car("Lambo","Urus",2010,250,9,engine,tyres);
           Console.WriteLine($"{car.FuelQuantity}");
           Console.WriteLine($"{car.Make}");
           Console.WriteLine($"{car.Model}");
          
           Console.WriteLine($"{car.FuelQuantity}");
        }
    }
}
