using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Owl:Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }
        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
        public override void Eat(string type, int quentity)
        {
            if (type != "Meat")
            {
                throw new ArgumentException($"Owl does not eat {type}!");
            }
            base.Eat(type, quentity);
            this.Weight += 0.25 * quentity;
        }
    }
}
