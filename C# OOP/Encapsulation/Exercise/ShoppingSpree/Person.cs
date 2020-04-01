using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        private List<Product> bag;

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            bag = new List<Product>();
        }


        public IReadOnlyList<Product> Bag
        {
            get => bag.ToList();
        }
        public string Name
        {
            get => name;
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                name = value;
            }
        }

        public double Money
        {
            get => money;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                money = value;
            }
        }

        public  void BuyProduct(Product product)
        {
            if (product.Cost > money)
            {
                throw new InvalidOperationException($"{name} can't afford {product.Name}");
            }

            money -= product.Cost;
            bag.Add(product);
        }

        public override string ToString()
        {
            string product = Bag.Count > 0 ? string.Join(", ", Bag) : "Nothing bought";

            return $"{Name} - {product}";
        }
    }
}
