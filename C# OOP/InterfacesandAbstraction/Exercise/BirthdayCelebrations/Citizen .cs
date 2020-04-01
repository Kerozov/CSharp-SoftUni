using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Citizen : IBirthable, IIdentifeable
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Birthdate { get; set; }

        public string IsCorrectYear(string year, string currYear)
        {
            if (currYear.EndsWith(year))
            {
                return currYear;
            }
            return null;
        }
        public string IsDestryed(string endNumber, string currId)
        {
            return null;
        }
    }
}
