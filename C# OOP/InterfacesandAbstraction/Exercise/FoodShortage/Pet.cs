using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    class Pet: IBirthable
    {
        public Pet(string Name,string birthdate)
        {
            this.Name = Name;
            this.Birthdate = birthdate;
        }
        public string Name { get; set; }
        public string Birthdate { get; set; }
        public string IsCorrectYear(string year, string currYear)
        {
                if (currYear.EndsWith(year))
                {
                    return currYear;
                }

                return null;
            }
        }
    }

