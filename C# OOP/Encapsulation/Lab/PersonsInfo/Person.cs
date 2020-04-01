using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        
        public Person(string fitstName, string lastName, int age, decimal salary)
        {
            this.FirstName = fitstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }
      
        public string FirstName { get;private set; }
        public decimal Salary { get;  set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} recives {this.Salary:f2} leva.";
        }
       
        public void IncreaseSalary(decimal percentage)
        {
            var delimiter = 100;
            if (this.Age <= 30)
            {
                delimiter = 200;
            }

            this.Salary += Salary * percentage / delimiter;
        }
    }
}
