using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace WildFarm
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var animals = new List<Animal>();
            var foods = new Stack<Food>();
            var count = 0;
            
            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    break;
                }
                if (count % 2 == 0)
                {
                    string type = input[0];
                    string name = input[1];
                    double weight = double.Parse(input[2]);
                    if (type == "Cat")
                    {
                        string livingRoom = input[3];
                        string bread = input[4];
                        animals.Add(new Cat(name, weight, livingRoom, bread));
                    }
                    else if (type == "Tiger")
                    {
                        string livingRoom = input[3];
                        string bread = input[4];
                        animals.Add(new Tiger(name, weight, livingRoom, bread));
                    }
                    else if (type == "Owl")
                    {
                        double wingSize = double.Parse(input[3]);
                        animals.Add(new Owl(name, weight, wingSize));
                    }
                    else if (type == "Hen")
                    {
                        double wingSize = double.Parse(input[3]);
                        animals.Add(new Hen(name, weight, wingSize));
                    }
                    else if (type == "Mouse")
                    {
                        string livingRoom = input[3];
                        animals.Add(new Mouse(name, weight, livingRoom));
                    }
                    else if (type == "Dog")
                    {
                        string livingRoom = input[3];
                        animals.Add(new Dog(name, weight, livingRoom));
                    }

                    Console.WriteLine(animals[animals.Count - 1].ProduceSound());
                }
                else
                {
                    string type = input[0];
                    int quantity = int.Parse(input[1]);
                    if (type == "Vegetable")
                    {
                        foods.Push(new Vegetable(quantity));
                    }
                    else if (type == "Fruit")
                    {
                        foods.Push(new Fruit(quantity));
                    }
                    else if (type == "Meat")
                    {
                        foods.Push(new Meat(quantity));
                    }
                    else if (type == "Seeds")
                    {
                        foods.Push(new Seeds(quantity));
                    }

                    var currFood = foods.Pop();
                    try
                    {
                        animals[animals.Count - 1].Eat(currFood.GetType().Name,currFood.Quantity);
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                count++;
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
