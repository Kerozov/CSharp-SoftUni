using NUnit.Framework;

namespace Robots.Tests
{
    using System;

    public class RobotsTests
    {
        private RobotManager robotManager;
        private Robot robot;
        [SetUp]
        public void Setup()
        {
             robotManager  =new RobotManager(3);
             robot = new Robot("Pesho",10);
        }
        [Test]
        public void ConstruvtorOnRorotWorkCorrectly()
        {
            string name = "Pesho";
            int maxBatery = 10;
            var robot = new Robot(name, maxBatery);
            Assert.AreEqual(name, robot.Name);
            Assert.AreEqual(maxBatery, robot.MaximumBattery);
            Assert.AreEqual(maxBatery,robot.Battery);
        }

        [Test]
        public void RobotManagerWorkCorrectly()
        {
            int capacity = 10;
            var robotManager=  new RobotManager(capacity);
            Assert.AreEqual(capacity,robotManager.Capacity);
            Assert.IsNotNull(robotManager);
        }

        [Test]
        public void CapacityThrowExceptionWothValueBelowZero()
        {
            int capacity = -1;
            Assert.Throws<ArgumentException>(()=> new RobotManager(capacity));
        }

        [Test]
        public void AddMethodWorkCorrectly()
        {
            robotManager.Add(robot);
            Assert.AreEqual(1, robotManager.Count);
        }

        [Test]
        public void AddMethodThrowExceptionWithExistingName()
        {
            robotManager.Add(robot);
            Assert.Throws<InvalidOperationException>(() => robotManager.Add(robot));
        }

        [Test]
        public void AddMethodThrowExceptionWithFullCapacity()
        {
            robotManager.Add(robot);
            robotManager.Add(new Robot("asn",40));
            robotManager.Add(new Robot("nvnf",20));
            Assert.Throws<InvalidOperationException>(() => robotManager.Add(new Robot("gonko",1)));
        }

        [Test]
        public void RemoveMethodWorkCorrectly()
        {
            robotManager.Add(robot);
            robotManager.Add(new Robot("asn", 40));
            robotManager.Remove(robot.Name);
            Assert.AreEqual(1,robotManager.Count);
        }

        [Test]
        public void RemoveMethodThrowExceptionWithDoesntExistName()
        {
            robotManager.Add(robot);
            robotManager.Add(new Robot("asn", 40));
            Assert.Throws<InvalidOperationException>(()=>robotManager.Remove("sdkdm"));
        }

        [Test]
        public void WorkMethodWorkCorrectly()
        {
            robotManager.Add(robot);
            robotManager.Work(robot.Name,"sjnv",1);
            Assert.AreEqual(9,robot.Battery);
        }

        [Test]
        public void WorkMethodThrowExceptionWithNullReference()
        {
            robotManager.Add(robot);
            Assert.Throws<InvalidOperationException>(()=>robotManager.Work(null, null, 1));
        }
        [Test]
        public void WorkMethodThrowExceptionWithBiggerUsage()
        {
            robotManager.Add(robot);
            Assert.Throws<InvalidOperationException>(() => robotManager.Work(robot.Name, null, 11));
        }

        [Test]
        public void ChargeMethodWorkCorrectly()
        {
            robotManager.Add(robot);
            robotManager.Work(robot.Name, robot.Name, 1);
            robotManager.Charge(robot.Name);
            Assert.AreEqual(10,robot.Battery);
        }
        [Test]
        public void ChargeMethodThrowEceptionWithNullReference()
        {
            robotManager.Add(robot);
            Assert.Throws<InvalidOperationException>((() => robotManager.Charge("sdkk")));

        }
    }
}
