using System;
using FightingArena;
using NUnit.Framework;

namespace Tests
{
    public class ArenaTests
    {
        private Arena arena;
        [SetUp]
        public void Setup()
        {
            arena = new Arena();
        }

        [Test]
        public void ConstructorsWorkCorrectly()
        {
            Assert.IsNotNull(arena.Warriors);
        }

        [Test]
        public void EnrollMethodThrowExceptionForExistingName()
        {
            var warrior = new Warrior("Pesho", 10, 100);
            arena.Enroll(warrior);
            Assert.Throws<InvalidOperationException>((() => arena.Enroll(warrior)));
        }
        [Test]
        public void EnrollMethodThrowExceptionForInvalidName()
        {
            var warrior = new Warrior("Pesho", 10, 100);
            var newWarrior = new Warrior("Pesho", 10, 100);
            arena.Enroll(warrior);
            Assert.Throws<InvalidOperationException>((() => arena.Enroll(newWarrior)));
        }
        [Test]
        public void EnrollMethodWorkCorrectly()
        {
            var warrior = new Warrior("Pesho", 10, 100);
            arena.Enroll(warrior);
            Assert.That(arena.Warriors,Has.Member(warrior));
        }

        [Test]
        public void CountWorkCorrectly()
        {
            var warrior = new Warrior("Pesho", 10, 100);
            arena.Enroll(warrior);
            int expectedCount = 1;
            int actualCount = this.arena.Count;
            Assert.AreEqual(expectedCount,actualCount);
        }

        [Test]
        public void TestAttackerMethodWithMissingAttacker()
        {
            var defenderWarrior = new Warrior("Gosho", 5, 50);
            var attackerWarrior = new Warrior("Pesho", 5, 50);
            arena.Enroll(defenderWarrior);
            Assert.Throws<InvalidOperationException>(()=>arena.Fight(attackerWarrior.Name,defenderWarrior.Name));
        }
        [Test]
        public void TestAttackerMethodWithMissingDefender()
        {
            var defenderWarrior = new Warrior("Gosho", 5, 50);
            var attackerWarrior = new Warrior("Pesho", 5, 50);
            arena.Enroll(attackerWarrior);
            Assert.Throws<InvalidOperationException>(() => arena.Fight(attackerWarrior.Name, defenderWarrior.Name));
        }
        [Test]
        public void FightMethodWorkCorrectly()
        {
            var attackerWarrior = new Warrior("Pesho", 10, 100);
            var defenderWarrior = new Warrior("Gosho", 5, 50);
            arena.Enroll(attackerWarrior);
            arena.Enroll(defenderWarrior);

            var expectedAttackerHP = attackerWarrior.HP - defenderWarrior.Damage;
            var expectedDefendererHP = defenderWarrior.HP - attackerWarrior.Damage;

            arena.Fight(attackerWarrior.Name,defenderWarrior.Name);
            Assert.AreEqual(expectedAttackerHP,attackerWarrior.HP);
            Assert.AreEqual(expectedDefendererHP,defenderWarrior.HP);
        }
    }
}
