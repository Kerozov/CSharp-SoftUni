using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Students
{
    class Student
    {
        public Student(string firstName,string lastName,double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}
