using System;
using System.Collections.Generic;

namespace _04_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double quantities = 0;
            var products = new Dictionary<string, List<double>>();
            while (input[0] != "buy")
            {
                string nameProduct = input[0];
                double price = double.Parse(input[1]);
                quantities = double.Parse(input[2]);
                if (!products.ContainsKey(nameProduct))
                {
                    products[nameProduct] = new List<double>();
                    products[nameProduct].Add(price);
                    products[nameProduct].Add(quantities);
                }
                else
                {
                    if (products.ContainsKey(nameProduct))
                    {
                        products[nameProduct][0] = price;
                        products[nameProduct][1] += quantities;
                    }
                    else
                    {
                        products[nameProduct].Add(price);
                        products[nameProduct].Add(quantities);
                    }
                }
                input = Console.ReadLine().Split();
            }
            foreach (var item in products)
            {
                var totalPrice = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {totalPrice:f2}");
            }

        }
    }
}


