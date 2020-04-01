using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
   public interface IBirthable
    {
        string Birthdate { get; set; }
        string IsCorrectYear(string year, string currYear);
    }
}
