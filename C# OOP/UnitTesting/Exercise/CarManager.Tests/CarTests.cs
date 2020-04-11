using System;
using CarManager;
using NUnit.Framework;

namespace Tests
{
    public class CarTests
    {
        private Car car;
        private string make = "Mercedes";
        private string model = "Benz";
        private double fuelConsumption = 10;
        private double fuelCapacity = 50;
        [SetUp]
        public void Setup()
        {
           
            car = new Car(make,model,fuelConsumption,fuelCapacity);
        }

        [Test]
        public void ConstrucyorWorkCorrectly()
        {
            Assert.AreEqual("Mercedes",car.Make);
            Assert.AreEqual("Benz",car.Model);
            Assert.AreEqual(10,car.FuelConsumption);
            Assert.AreEqual(50,car.FuelCapacity);
            Assert.AreEqual(0,car.FuelAmount);
        }

        [Test]
        public void ConstructorThrowExeptionWithNullRefernce()
        {
            Assert.Throws<ArgumentException>(() => new Car(null, model, fuelConsumption, fuelCapacity));
            Assert.Throws<ArgumentException>(() => new Car(make, null, fuelConsumption, fuelCapacity));
            Assert.Throws<ArgumentException>(() => new Car(make, model, 0, fuelCapacity));
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, 0));
        }

        [Test]
        public void RefuelMethodWorkCorrectly()
        {
            double expectedFuel = car.FuelAmount + 10;
            car.Refuel(10);
            double actualFuel = car.FuelAmount;
            Assert.AreEqual(expectedFuel,actualFuel);
        }

        [Test]
        public void RefuelMethodThrowExeptionWithZeroFuel()
        {

            Assert.Throws<ArgumentException>(() => car.Refuel(0));
        }

        [Test]
        public void FuelAmountIsEqualToFuelCapacityWhenCapacityIsToLower()
        {
            double expected = car.FuelCapacity;
          car.Refuel(600);
          Assert.AreEqual(expected,car.FuelAmount);
        }

        [Test]
        public void DriveMethodWorCorrectly()
        {
            car.Refuel(30);
            car.Drive(10);
            double expected = 29;
            Assert.AreEqual(expected,car.FuelAmount);
        }

        [Test]
        public void DriveMethodThrowExceptionWithBiggerFuelNeeded()
        {
            Assert.Throws<InvalidOperationException>(() => car.Drive(1));
        }
    }
}