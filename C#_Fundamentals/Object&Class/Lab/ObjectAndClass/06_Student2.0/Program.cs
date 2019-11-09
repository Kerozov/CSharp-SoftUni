using System;
using System.Collections.Generic;

namespace _06_Student2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var students =new List<Student>();
            while (line!= "end")
            {
                string[] information = line.Split();
                var student = new Student();
               
                if (student.isExist(students, information[0], information[1]))
                {
                    foreach (var item in students)
                    {

                        if (item.firstName == information[0] && item.lastName == information[1])
                        {
                            item.age= int.Parse(information[2]);
                            item.homeTown = information[3];
                        }
                    }
                }
                else
                {
                    student.firstName = information[0];
                    student.lastName = information[1];
                    student.age = int.Parse(information[2]);
                    student.homeTown = information[3];
                    students.Add(student);
                }
                line = Console.ReadLine();
            }
            string homeTown = Console.ReadLine();
            foreach (var item in students)
            {
                if (homeTown == item.homeTown)
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
    public int age { get; set; }
    public string homeTown { get; set; }

    public bool isExist(List<Student> students, string firstName, string lastName)
    {
        foreach (var item in students)
        {
            if (item.firstName == firstName && item.lastName == lastName)
            {

                return true;
            }
        }
        return false;
    }
}
