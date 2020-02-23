using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    class Person
    {
        public Person()
        {
            name = "No name";
            age = 1;
        }

        public Person(int Age)
        : this()
        {
            age = Age;
        }

        public Person(string Name, int Age)
        : this(Age)
        {
            name = Name;
        }


        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 30)
                {
                    age = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{name} {age}";
        }
    }
}
