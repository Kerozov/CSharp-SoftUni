using System;
using System.Collections.Generic;
using System.Linq;


namespace _09_ListofPredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<Predicate<int>> predicates = new List<Predicate<int>>();
            foreach (var devNum in input)
            {
                predicates.Add(new Predicate<int>(x=>x%devNum==0));
            }

            var isTrue = true;
            var output = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                isTrue = true;
                foreach (var predicate in predicates)
                {
                    if (!predicate(i))
                    {
                        isTrue = false;
                    }
                }
                if (isTrue)
                {
                    output.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ",output));
        }
    }
}
