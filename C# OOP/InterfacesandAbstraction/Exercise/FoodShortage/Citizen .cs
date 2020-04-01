using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Citizen : IBirthable, IIdentifeable,IBuyer
    {
        private List<string> citizens = new List<string>();
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
            citizens.Add(name);
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Birthdate { get; set; }
        public int Food { get; private set; } = 0;

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

        public void BuyFood(string name)
        {

            bool isExist = false;
            foreach (var curr in citizens)
            {
                if (curr == name)
                {
                    isExist = true;
                }
            }

            if (isExist)
            {
                Food += 10;
            }
        }

     

    }
}
