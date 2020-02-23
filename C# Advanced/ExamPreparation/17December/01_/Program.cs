using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_
{
    class Program
    {
        static void Main(string[] args)
        {
            var materialsInput = Console.ReadLine()
                 .Split()
                 .Select(int.Parse);
            var magicNumbersInput = Console.ReadLine()
                 .Split()
                 .Select(int.Parse);
            var materials = new Stack<int>(materialsInput);
            var magicNumbers = new Queue<int>(magicNumbersInput);
            var product = new Dictionary<string, int>();
            var doll = 0;
            var woodenTrain = 0;
            var teddyBear = 0;
            var bicycle = 0;
            var flag = false;
            while (materials.Count > 0 && magicNumbers.Count > 0)
            {
                flag = false;
                var currMateral = materials.Peek();
                var currMagicNumber = magicNumbers.Peek();
                if (materials.Count > 0)
                {
                    if (currMateral == 0)
                    {
                        materials.Pop();
                        flag = true;
                    }
                }
                if (magicNumbers.Count > 0)
                {
                    if (currMagicNumber == 0)
                    {
                        magicNumbers.Dequeue();
                        flag = true;
                    }
                }
                if (flag)
                {
                    continue;
                }
                materials.Pop();
                magicNumbers.Dequeue();
                var maltiply = currMagicNumber * currMateral;
                switch (maltiply)
                {
                    case 150:
                        if (!product.ContainsKey("Doll"))
                        {
                            product["Doll"] = 0;
                        }
                        product["Doll"]++;
                        doll++;
                        break;
                    case 250:
                        if (!product.ContainsKey("Wooden train"))
                        {
                            product["Wooden train"] = 0;
                        }
                        product["Wooden train"]++;
                        woodenTrain++;
                        break;
                    case 300:
                        if (!product.ContainsKey("Teddy bear"))
                        {
                            product["Teddy bear"] = 0;
                        }
                        product["Teddy bear"]++;
                        teddyBear++;
                        break;
                    case 400:
                        if (!product.ContainsKey("Bicycle"))
                        {
                            product["Bicycle"] = 0;
                        }
                        product["Bicycle"]++;
                        bicycle++;
                        break;
                    default:
                        if (maltiply < 0)
                        {
                            var sum = currMateral+ currMagicNumber;
                            materials.Push(sum);
                        }
                        else
                        {
                            materials.Push(currMateral + 15);
                        }
                        break;

                }

               


            }
            PrintOutput(materials, magicNumbers, product, doll, woodenTrain, teddyBear, bicycle);
        }

        private static void PrintOutput(Stack<int> materials, Queue<int> magicNumbers, Dictionary<string, int> product, int doll, int woodenTrain, int teddyBear, int bicycle)
        {
            if ((doll > 0 && woodenTrain > 0))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else if ((teddyBear > 0 && bicycle > 0))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }
            if (materials.Count > 0)
            {
                Console.WriteLine($"Materials left: {string.Join(", ", materials)}");
            }
            if (magicNumbers.Count > 0)
            {
                Console.WriteLine($"Magic left: {string.Join(", ", magicNumbers)}");
            }
            foreach (var item in product.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
