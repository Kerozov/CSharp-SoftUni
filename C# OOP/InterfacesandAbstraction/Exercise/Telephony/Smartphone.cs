using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
   public class Smartphone :ICallable,IBrowseable
    {
        public string Call(string phoneNumber)
        {
            return $"Calling... {phoneNumber}";
        }

        public string Browse(string sites)
        {
            return $"Browsing: {sites}!";
        }
    }
}
