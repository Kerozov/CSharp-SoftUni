using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
   public class RandomList :List<string>
    {
        public string RandomString()
        {
            var random = new Random();
            var index = random.Next(0, this.Count-1);
            if (this.Count>0)
            {
                this.RemoveAt(index);
                return this[index];
            }

            return null;
        }
    }
}
