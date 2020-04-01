using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodShortage
{
    class Rebel :IBuyer
    {
        private List<string> rebels =  new List<string>();
        public Rebel(string name,int age,string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
            this.rebels.Add(name);
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
      
        public int Food { get; private set; } = 0;

        public void BuyFood(string name)
        {

            bool isExist = false;
            foreach (var curr in rebels)
            {
                if (curr == name)
                {
                    isExist = true;
                }
            }

            if (isExist)
            {
                Food += 5;
            }
        }
    }
}
