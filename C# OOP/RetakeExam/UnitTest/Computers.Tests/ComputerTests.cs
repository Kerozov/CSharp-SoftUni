using System;
using System.Runtime.CompilerServices;
using NuGet.Frameworks;

namespace Computers.Tests
{
    using NUnit.Framework;

    public class ComputerTests
    {
        private Computer computer;
        private Part part;
        [SetUp]
        public void Setup()
        {
            computer  =new Computer("Acer");
            part = new Part("SSD",10);
        }

        [Test]
        public void ConstructorWorkCorrectly()
        {
         var computer = new Computer("Acer");
            Assert.AreEqual("Acer",computer.Name);
            Assert.IsNotNull(computer.Parts);
        }

        [Test]
        public void ConstructorThrowExceptionWithNullReference()
        {
            Assert.Throws<ArgumentNullException>((() => new Computer(null)));
        }

        [Test]
        public void AddPArtMethod()
        {
            computer.AddPart(part);
            Assert.AreEqual(1,computer.Parts.Count);
        }

        [Test]
        public void AddMethodThrowExceptionWithNullPArtReference()
        {
            Assert.Throws<InvalidOperationException>(((() => computer.AddPart(null))));
        }

        [Test]
        public void TotalSumWorkCorretly()
        {
            computer.AddPart(part);
            computer.AddPart(new Part("Mishka",60));
            decimal actualPrice = computer.TotalPrice;
            decimal expectedPrice = 70;
            Assert.AreEqual(expectedPrice,actualPrice);

        }

        [Test]
        public void RemoveMethodWorkCorrectly()
        {
            computer.AddPart(part);
            computer.AddPart(new Part("Mishka", 60));
            computer.RemovePart(part);
            Assert.AreEqual(1,computer.Parts.Count);
        }

        [Test]
        public void GetPartMethodWorkCorrectly()
        {
            computer.AddPart(part);
            Part part1 = computer.GetPart(this.part.Name);
            Assert.AreEqual(part.Name,part1.Name);
        }
    }
}