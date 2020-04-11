using System;
using FightingArena;
using NUnit.Framework;

namespace Tests
{
    public class WarriorTests
    {
        
        private Warrior warrior;
        [SetUp]
        public void Setup()
        {
            warrior = new Warrior("Pesho",10,100);
        }

        [Test]
        public void ConstructorWorkCorrectly()
        {
            warrior = new Warrior("Pesho", 10, 100);
            Assert.AreEqual("Pesho",warrior.Name);
            Assert.AreEqual(10,warrior.Damage);
            Assert.AreEqual(100,warrior.HP);
        }

        [Test]
        public void ConstructorThrowExeptionWithNullReference()
        {
            Assert.Throws<ArgumentException>(() => new Warrior(null, 10, 100));
            Assert.Throws<ArgumentException>(() => new Warrior("Pesho", 0, 100));
            Assert.Throws<ArgumentException>(() => new Warrior("Pesho", -10, 100));
            Assert.Throws<ArgumentException>(() => new Warrior("Pesho", 10, -10));
            Assert.Throws<ArgumentException>(() => new Warrior(string.Empty, 10, 100));
            Assert.Throws<ArgumentException>(() => new Warrior("     ", 10, 100));
        }

        [Test]
        public void AttackMethodWorkCorrectly()
        {
            var attackWarrior = new Warrior("ivan",5,50);
            warrior.Attack(attackWarrior);
            int expectionAttackWarriorHp = 40;
            int expectionWarriorHp = 95;
            Assert.AreEqual(expectionWarriorHp,warrior.HP);
            Assert.AreEqual(expectionAttackWarriorHp,attackWarrior.HP);
        }

        [Test]
        public void AttackWarriorWithSmallHP()
        {
            warrior = new Warrior("Gosho",50,200);
            var attackWarrior = new Warrior("ivan", 2, 31);
            warrior.Attack(attackWarrior);
            int expectionAttackWarriorHp = 0;
            int expectionWarriorHp = 198;
            Assert.AreEqual(expectionWarriorHp, warrior.HP);
            Assert.AreEqual(expectionAttackWarriorHp, attackWarrior.HP);
        }

        [Test]
        [TestCase(25)]
        [TestCase(30)]
        public void AttackMethodThrowExeptionForMinHp(int attackerHP)
        {
            string attackerName = "Pesho";
            int attackerDmg = 10;

            string defenderName = "gosho";
            int defenderHP = 40;
            int defenderDmg = 10;

            var attacker = new Warrior(attackerName,attackerDmg,attackerHP);
            var defender = new Warrior(defenderName,defenderDmg,defenderHP);
            Assert.Throws<InvalidOperationException>((() => attacker.Attack(defender)));
        }
        [Test]
        [TestCase(25)]
        [TestCase(30)]
        public void AttackMethodThrowExeptionForMinHpDefender(int defenderHP)
        {
            string attackerName = "Pesho";
            int attackerDmg = 10;
            int attackerHP = 40;

            string defenderName = "gosho";
            int defenderDmg = 10;

            var attacker = new Warrior(attackerName, attackerDmg, attackerHP);
            var defender = new Warrior(defenderName, defenderDmg, defenderHP);
            Assert.Throws<InvalidOperationException>((() => attacker.Attack(defender)));
        }

        [Test]
        public void AttackingStrongerEnemyThrowExeption()
        {
            string attackerName = "Pesho";
            int attackerDmg = 10;
            int attackerHP = 35;

            string defenderName = "gosho";
            int defenderDmg = 40;
            int defenderHP = 100;

            var attacker = new Warrior(attackerName, attackerDmg, attackerHP);
            var defender = new Warrior(defenderName, defenderDmg, defenderHP);
            Assert.Throws<InvalidOperationException>((() => attacker.Attack(defender)));
        }
    }
}