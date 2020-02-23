using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01_
{
    class Program
    {
        static void Main(string[] args)
        {
            var chemical = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();
            var physicalItem = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();
            var chemicalQueue = new Queue<int>(chemical);
            var physicalStack = new Stack<int>(physicalItem);

            var glass = 0;
            var aluminium = 0;
            var lithium = 0;
            var carbon = 0;
            while (chemicalQueue.Count > 0 && physicalStack.Count > 0)
            {
                var liquid = chemicalQueue.Dequeue();
                var item = physicalStack.Pop();

                var sum = liquid + item;
                switch (sum)
                {
                    case 25:
                        glass++;
                        break;
                    case 50:
                        aluminium++;
                        break;
                    case 75:
                        lithium++;
                        break;
                    case 100:
                        carbon++;
                        break;
                    default:
                        physicalStack.Push(item + 3);
                        break;
                }
            }
         
            if (glass > 0 && aluminium > 0 && lithium > 0 && carbon > 0)
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }
            string leftLiquids = chemicalQueue.Count == 0 ? "none" : string.Join(", ", chemicalQueue);
            Console.WriteLine($"Liquids left: {leftLiquids}");
            string leftItem = physicalStack.Count == 0 ? "none" : string.Join(", ", physicalStack);
            Console.WriteLine($"Physical items left: {leftItem}");

            Console.WriteLine($"Aluminium: {aluminium}");
            Console.WriteLine($"Carbon fiber: {carbon}");
            Console.WriteLine($"Glass: {glass}");
            Console.WriteLine($"Lithium: {lithium}");


        }
    }
}
