using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using ShoppingSpree;
namespace ShoppingSpree.Core
{
    public class Engine
    {
        private List<Person> people;
        private List<Product> products;

        public Engine()
        {
            people = new List<Person>();
            products = new List<Product>();
        }
        public void Run()
        {
            CheckProductsAndPeople();

            while (true)
            {
                var command = Console.ReadLine();
                if (command=="END")
                {
                    break;
                }

                var args = command.Split();
                try
                {
                    var person = people
                        .First(p => p.Name == args[0]);
                    var product = products
                        .First(p => p.Name == args[1]);
                    person.BuyProduct(product);
                    Console.WriteLine($"{person.Name} - {product.Name}");
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }

        private void CheckProductsAndPeople()
        {
            var peopleArgs = Console.ReadLine()
                .Split(';',StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            for (int i = 0; i < peopleArgs.Length; i++)
            {
                string[] currPerson = peopleArgs[i].Split('=');
                string name = currPerson[0];
                double money = double.Parse(currPerson[1]);
                var person = new Person(name, money);
                this.people.Add(person);
            }

            var productArgs = Console.ReadLine()
                .Split(';',StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            foreach (var productsArg in productArgs)
            {
                var currProduct = productsArg.Split('=');
                string name = currProduct[0];
                double cost = double.Parse(currProduct[1]);
                var product = new Product(name, cost);
                products.Add(product);
            }
        }
    }
}
