using System.Linq;
using NUnit.Framework;

namespace Presents.Tests
{
    using System;

    public class PresentsTests
    {
        private Present present;
        private Bag bag;
        [SetUp]
        public void SetUp()
        {
            bag = new Bag();
            present = new Present("Laptop",10.10);
        }
        [Test]
        public void ConstructorOnPresentWorkCorrectly()
        {
            string name = "Pesho";
            double magic = 10.1;
            var present = new Present(name, magic);
            Assert.AreEqual(name,present.Name);
            Assert.AreEqual(magic,present.Magic);
        }

        [Test]
        public void ConstructorOnBagWorkCorrectly()
        {
            var bag = new Bag();
            Assert.IsNotNull(bag);
        }

        [Test]
        public void CreateMethodWorCorrectly()
        {
            bag.Create(present);
            int expCount = 1;
            int actCount = bag.GetPresents().Count;
            Assert.AreEqual(expCount,actCount);
        }
        [Test]
        public void CreateMethodThrowExeptionWithNullPresent()
        {
            bag.Create(present);
            Assert.Throws<ArgumentNullException>(()=>bag.Create(null));
        }
        [Test]
        public void CreateMethodThrowExeptionWithExistingPresent()
        {
            bag.Create(present);
            Assert.Throws<InvalidOperationException>(() => bag.Create(present));
        }

        [Test]
        public void RemoveMethodWorkCorrectly()
        {
            bag.Create(present);
            Assert.AreEqual(true,bag.Remove(present));
            Assert.AreEqual(false, bag.Remove(present));
            Assert.AreEqual(0,bag.GetPresents().Count);
        }

        [Test]
        public void LeastMethodWorkCorrectly()
        {
            bag.Create(present);
            bag.Create(new Present("Pesho",10));
            bag.Create(new Present("Gosho",15));
            bag.Create(new Present("Todor",1));
            bag.Create(new Present("Nqkyw",7));
            var expectedPresent = bag.GetPresents().OrderBy(p => p.Magic).First();
            var actualPresent = bag.GetPresentWithLeastMagic();
            Assert.AreEqual(expectedPresent.Name,actualPresent.Name);
            Assert.AreEqual(expectedPresent.Magic,actualPresent.Magic);
        }

        [Test]
        public void GetPresentMethodWorkCorrectly()
        {
            bag.Create(present);
            bag.Create(new Present("Pesho", 10));
            var actualPresent = bag.GetPresent(present.Name);
            var expectedPresent = present;
            Assert.AreEqual(expectedPresent.Name,actualPresent.Name);
        }

        [Test]
        public void GetPresentReturnNull()
        {
            bag.Create(present);
            bag.Create(new Present("Pesho", 10));
            var actualPresent = bag.GetPresent(null);
            string expectedPresent = null;
            Assert.AreEqual(expectedPresent, actualPresent);
        }
    }
}
