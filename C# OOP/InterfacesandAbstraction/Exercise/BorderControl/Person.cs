using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Person : IIdentifeable
    {
        public Person(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; private set; }
        public string IsDestryed(string endNumber, string currId)
        {
            if (currId.EndsWith(endNumber))
            {
                return currId;


            }

            return null;
        }

    
    }
}
