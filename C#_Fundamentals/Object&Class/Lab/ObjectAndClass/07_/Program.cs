using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var boxes = new List<Box>();
            
            while (line != "end")
            {
                string[] information = line.Split();
                var box = new Box();
                box.serialNumber = int.Parse(information[0]);
                box.item = information[1];
                box.itemQuantity = int.Parse(information[2]);
                box.priceItem = double.Parse(information[3]);
                box.priceForBox = box.priceItem * box.itemQuantity;
                boxes.Add(box);
                line = Console.ReadLine();
            }
            var newList = boxes.OrderBy(x => x.priceForBox).ToList();
            newList.Reverse();
            foreach (var box in newList)
            {
                Console.WriteLine(box.serialNumber);
                Console.WriteLine($"-- {box.item} - ${box.priceItem:f2}: {box.itemQuantity}");
                Console.WriteLine($"-- ${box.priceForBox:f2}");


            }
        }
    }
}
class Box
{
    public int serialNumber { get; set; }
    public string item { get; set; }
    public int itemQuantity { get; set; }
    public double priceForBox { get; set; }
    public double priceItem { get; set; }
}
