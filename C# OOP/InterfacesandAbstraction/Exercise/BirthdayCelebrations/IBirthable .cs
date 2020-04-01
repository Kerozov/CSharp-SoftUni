using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
   public interface IBirthable
    {
        string Birthdate { get; set; }
        string IsCorrectYear(string year, string currYear);
    }
}
