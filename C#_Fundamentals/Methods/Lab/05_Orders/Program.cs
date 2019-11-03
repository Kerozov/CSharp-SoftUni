using System;

namespace _05_Orders
{
    class Program
    {
        static double price(string productName,int number,double price )
        {
            
            switch (productName)
            {
                case "coffee":
                    price += 1.50;
                    break;
                case "coke":
                    price += 1.40;
                    break;
                case "water":
                    price += 1.00;
                    break;
                case "snacks":
                    price += 2.00;
                    break;
            }
            return price;
        }
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            int numberProduct = int.Parse(Console.ReadLine());
            double alllPrice = 0;
            for (int i = 0; i < numberProduct; i++)
            {
                alllPrice += price(productName, numberProduct,0);
            }
                Console.WriteLine($"{alllPrice:f2}");
        }
    }
}
