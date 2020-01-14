using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] information = Console.ReadLine().Split();
                string firstName = information[0];
                string LastName = information[1];
                double grade = double.Parse(information[2]);
                var studdent = new Student(firstName, LastName, grade);
                students.Add(studdent);
            }
             List<Student> newList = students.OrderBy(o => o.Grade).ToList();
            newList.Reverse();
            foreach (var item in newList)
            {
            Console.WriteLine($"{ item.FirstName} {item.LastName}: {item.Grade:f2}");
               
            }
        }
    }
}
