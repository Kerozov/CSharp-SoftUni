using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05_FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var clotches = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            var capacity = int.Parse(Console.ReadLine());
            int countBox = 0;
            int current = 0;
            while (true)
            {
                if (clotches.Count()==0)
                {
                    break;
                }
                 current += clotches.Peek();
                if (capacity==current)
                {
                    clotches.Pop();
                    countBox++;
                    current = 0;
                }
                else if (capacity < current)
                {
                    countBox++;
                    current = 0;
                }
                else
                {
                    clotches.Pop();
                }
            }

            if (current>0)
            {
                countBox++;
            }
            Console.WriteLine(countBox);
        }
    }
}
