using System;
using System.Collections.Generic;
namespace _05_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var information = new List<Student>();
            while (line != "end")
            {
                string[] anketa = line.Split();
                var text = new Student();
                text.firstName = anketa[0];
                text.lastName = anketa[1];
                text.homeTown = anketa[3];
                text.age = int.Parse(anketa[2]);
                information.Add(text);
                line = Console.ReadLine();
            }
            string homeTown = Console.ReadLine();
            foreach (var item in information)
            {
                if (homeTown==item.homeTown)
                {
                    Console.WriteLine($"{item.firstName} {item.lastName} is {item.age} years old.");
                }
            }
        }
    }
}
class Student
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string homeTown { get; set; }
    public int age { get; set; }
}
