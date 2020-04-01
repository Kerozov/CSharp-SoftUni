using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }
        public override string ProduceSound()
        {
            return "Squeak";
        }

        public override void Eat(string type, int quentity)
        {
            if ((type == "Fruit" || type == "Vegetable"))
            {
                base.Eat(type, quentity);
                this.Weight += 0.10 * quentity;
            }
            else
            {
                throw new ArgumentException($"Mouse does not eat {type}!");

            }

        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
