using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstBoxInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var secondBoxInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var firstBox = new Stack<int>(secondBoxInput);
            var secondBox = new Queue<int>(firstBoxInput);
            var colection = new List<int>();
            while (firstBox.Count > 0 && secondBox.Count > 0)
            {
                var firstElement = firstBox.Peek();
                var secondElement = secondBox.Peek();
                var sum = firstElement + secondElement;
                if (sum % 2 == 0)
                {
                    firstBox.Pop();
                    secondBox.Dequeue();
                    colection.Add(sum);
                }
                else
                {
                    var lastIndex = firstBox.Pop();
                    secondBox.Reverse();
                    secondBox.Enqueue(lastIndex);
                        secondBox.Reverse();
                }
            }
            if (secondBox.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else
            {
                Console.WriteLine("Second lootbox is empty");
            }
            if (colection.Sum() >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {colection.Sum()}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {colection.Sum()}");
            }
        }
    }
}
