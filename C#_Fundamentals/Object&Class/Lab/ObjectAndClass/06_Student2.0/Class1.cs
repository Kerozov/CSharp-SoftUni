using System;
using System.Collections.Generic;
using System.Text;

namespace _06_Student2._0
{
    class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string homeTown { get; set; }
        
        public bool isExist(List<Student> students,string firstName,string lastName)
        {
            foreach (var item in students)
            {
                if (item.firstName==firstName&&item.lastName==lastName)
                {
                    
                    return true;
                }
            }
            return false;
        }
    }
}
