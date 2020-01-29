using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var foodShops = new Dictionary<string, Dictionary<string, double>>();
            while (true)
            {
                string[] command = Console.ReadLine().Split(", ");
                if (command[0]=="Revision")
                {
                    break;
                }

                string shopPleace = command[0];
                string product = command[1];
                double price = double.Parse(command[2]);
                if (!foodShops.ContainsKey(shopPleace))
                {
                    foodShops.Add(shopPleace,new Dictionary<string, double>());
                }

                if (!foodShops[shopPleace].ContainsKey(product))
                {
                    foodShops[shopPleace].Add(product,price);
                }

            }

            foreach (var food in foodShops.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{food.Key}->");
                foreach (var product in food.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
