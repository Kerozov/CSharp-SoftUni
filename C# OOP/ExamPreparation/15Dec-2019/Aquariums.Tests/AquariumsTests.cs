
using System;
using NUnit.Framework;

namespace Aquariums.Tests
{
    public class AquariumsTests
    {
        private Aquarium aquarium;
        private Fish fish;

        [SetUp]
        public void SetUp()
        {
            aquarium = new Aquarium("Domashen", 2);
            fish= new Fish("Pesho");
        }

        [Test]
        public void FishProperty()
        {
            fish= new Fish("Pesho");
            fish.Name = "Gosho";
            fish.Available = false;
            Assert.AreEqual("Gosho",fish.Name);
            Assert.AreEqual(false, fish.Available);


        }
        [Test]
        public void ConstructorFishWorkCorrectly()
        {
            var fish = new Fish("Pesho");
            Assert.AreEqual("Pesho",fish.Name);
            Assert.AreEqual(true,fish.Available);

        }

        [Test]
        public void ConstructorAquariumWorkCorrectly()
        {
            var aquarium = new Aquarium("Pesho",10);
            Assert.AreEqual("Pesho", aquarium.Name);
            Assert.AreEqual(10, aquarium.Capacity);
            aquarium.Add(fish);
            Assert.AreEqual(1, aquarium.Count);
            Assert.IsNotNull(aquarium);
        }

        [Test]
        public void ConstructorOnAquarimThrowExceptionWithInvalidName()
        {
            Assert.Throws<ArgumentNullException>((() => new Aquarium(null, 10)));
            Assert.Throws<ArgumentNullException>((() => new Aquarium("", 10)));

        }
        [Test]
        public void ConstructorOnAquarimThrowExceptionWithInvalidCapacity()
        {
            Assert.Throws<ArgumentException>((() => new Aquarium("Pesho", -1)));
        }

        [Test]
        public void AddMethodWorkCorrectly()
        {
            aquarium.Add(fish);
            Assert.AreEqual(1,aquarium.Count);
        }

        [Test]
        public void AquriumMethodThrowExceptionWithFullCapacity()
        {
            aquarium.Add(fish);
            aquarium.Add(new Fish("sxvn"));
            Assert.Throws<InvalidOperationException>((() => aquarium.Add(new Fish("Gosho"))));
        }

        [Test]
        public void RemoveMethodWorkCorrectly()
        {
            aquarium.Add(fish);
            aquarium.RemoveFish(fish.Name);
            Assert.AreEqual(0,aquarium.Count);
        }

        [Test]
        public void RemoveMethodThrowExceptionWithNotExistingName()
        {
            Assert.Throws<InvalidOperationException>((() => aquarium.RemoveFish(null)));
        }

        [Test]
        public void SellFishWorkCorrectly()
        {
            aquarium.Add(fish);
            Assert.AreEqual(fish.Name, aquarium.SellFish(fish.Name).Name);
            Assert.AreEqual(false,fish.Available);
        }

        [Test]
        public void SellFishThrowExceptionWithNotExistingName()
        {
            Assert.Throws<InvalidOperationException>((() => aquarium.SellFish("NotExistingFish")));
        }

        [Test]
        public void reportMethodWorkCorrectly()
        {
            aquarium.Add(fish);
            string expectionMessages = $"Fish available at Domashen: Pesho";
            string actualMessages = aquarium.Report();
            Assert.AreEqual(expectionMessages,actualMessages);
        }
        [Test]
        public void reportMethodWorkCorrectlyWithMoreParameter()
        {
            aquarium.Add(fish);
            aquarium.Add(new Fish("Gosho"));

            string expectionMessages = $"Fish available at Domashen: Pesho, Gosho";
            string actualMessages = aquarium.Report();
            Assert.AreEqual(expectionMessages, actualMessages);
        }
    }
}
