using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
   public class Dog:Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }
        public override void Eat(string type, int quentity)
        {
            if (type != "Meat")
            {
                throw new ArgumentException($"Dog does not eat {type}!");
            }
            base.Eat(type, quentity);
            this.Weight += 0.40 * quentity;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
