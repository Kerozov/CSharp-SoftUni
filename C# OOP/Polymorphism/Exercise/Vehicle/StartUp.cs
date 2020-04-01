using System;

namespace Vehicle
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var car = CarInitial();
            var truck = TruckInitial();
            var bus = BusInitial(); 
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandArg = Console.ReadLine().Split();
                var command = commandArg[0];
                var model = commandArg[1];
                var km = double.Parse(commandArg[2]);
                try
                {
                    if (model == "Car")
                    {
                        if (command == "Drive")
                        {
                            Console.WriteLine(car.Drive(km));
                        }
                        else
                        {
                            car.Reefuel(km);
                        }
                    }
                    else if (model == "Truck")
                    {
                        if (command == "Drive")
                        {
                            Console.WriteLine(truck.Drive(km));
                        }
                        else
                        {
                            truck.Reefuel(km);
                        }
                    }
                    else if (model == "Bus")
                    {
                        if (command == "Drive")
                        {
                            Console.WriteLine(bus.Drive(km,false));
                        }

                        else if (command == "DriveEmpty")
                        {
                            bus.Drive(km, true);
                        }
                        else
                        {
                            bus.Reefuel(km);
                        }
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }

        private static Bus BusInitial()
        {
            var busArg = Console.ReadLine().Split();
            var busFuel = double.Parse(busArg[1]);
            var busLiter = double.Parse(busArg[2]);
            var busTankCapacity = int.Parse(busArg[3]);
            if (busLiter>busTankCapacity)
            {
                busLiter = 0;
            }
            return new Bus(busFuel, busLiter, busTankCapacity);
        }

        private static Truck TruckInitial()
        {
            var truckArg = Console.ReadLine().Split();
            var truckFuel = double.Parse(truckArg[1]);
            var truckLiter = double.Parse(truckArg[2]);
            var truckTankCapacity = int.Parse(truckArg[3]);
            if (truckLiter > truckTankCapacity)
            {
                truckLiter = 0;
            }
            return new Truck(truckFuel, truckLiter, truckTankCapacity);
        }

        private static Car CarInitial()
        {
            var carArg = Console.ReadLine().Split();
            var carFuel = double.Parse(carArg[1]);
            var carLiter = double.Parse(carArg[2]);
            var carTankCapacity = int.Parse(carArg[3]);
            if (carLiter > carTankCapacity)
            {
                carLiter = 0;
            }
            return new Car(carFuel, carLiter, carTankCapacity);
        }
    }
}

