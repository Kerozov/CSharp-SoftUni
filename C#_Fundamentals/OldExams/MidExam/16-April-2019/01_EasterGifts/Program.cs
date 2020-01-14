using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_EasterGifts
{
    class Program
    {
        static void Main(string[] args)
       
        {
            List<string> gifts = Console.ReadLine()
                .Split()
                .ToList();
            string line = Console.ReadLine();
            while (line != "No Money")
            {
                string[] lines = line.Split();
                string command = lines[0];
                if (command == "OutOfStock")
                {
                    for (int i = 0; i < gifts.Count; i++)
                    {
                        if (gifts[i]==lines[1])
                        {
                            gifts[i] = "None";
                        }
                    }
                }
                else if (command == "Required")
                {
                    string newGift = lines[1];
                    int index =int.Parse(lines[2]);
                    if (index>=0&&index<gifts.Count)
                    {
                        gifts[index] = newGift;
                    }
                }
                else if (command == "JustInCase")
                {
                    string newGift = lines[1];
                    gifts[gifts.Count - 1] = newGift;

                }
                line = Console.ReadLine();
            }
            List<string> printList = new List<string>();
            foreach (var item in gifts)
            {
                if (item!="None")
                {
                    printList.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ",printList));
        }
    }
}
