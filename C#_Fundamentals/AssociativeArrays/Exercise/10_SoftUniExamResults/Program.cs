using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_SoftUniExamResults
{
    class Program
    {


        static void Main(string[] args)
        {
            var students = new Dictionary<string, int>();
            var courses = new Dictionary<string, int>();
            while (true)
            {
                string[] input = Console.ReadLine().Split('-');
                if (input[0] == "exam finished")
                {
                    break;
                }
                string userName = input[0];
                string language = input[1];
                if (input.Length > 2)
                {
                    int point = int.Parse(input[2]);
                    if (!students.ContainsKey(userName))
                    {
                        students[userName] = 0;
                    }
                    if (students[userName] < point)
                    {
                        students[userName] = point;
                    }
                    if (!courses.ContainsKey(language))
                    {
                        courses[language] = 0;
                    }
                    courses[language]++;
                }
                else
                {
                    students.Remove(userName);
                }
            }
            var newStudents = students.OrderByDescending(s => s.Value).ThenBy(s => s.Key);
            var newCourses = courses.OrderBy(c => c.Key);
            Console.WriteLine("Results:");
            foreach (var s in newStudents)
            {
                Console.WriteLine($"{s.Key} | {s.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var c in newCourses)
            {
                Console.WriteLine($"{c.Key} - {c.Value}");
            }
        }
    }
}

