using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var students = new Dictionary<string,List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                if (!students.ContainsKey(input[0]))
                {
                    students[input[0]] = new List<decimal>();
                }
                students[input[0]].Add(decimal.Parse(input[1]));
            }

            foreach (var grades in students)
            {
                var averge = grades.Value.Average();
                Console.Write($"{grades.Key} -> ");
                foreach (var grade in grades.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {averge:f2})");
            }
        }
    }
}
