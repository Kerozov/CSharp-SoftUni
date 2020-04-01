using System;
using System.Collections.Generic;
using System.Text;
using BirthdayCelebrations;

namespace BirthdayCelebrations
{
  public  class Robot:IIdentifeable
    {
        public Robot(string model,string id)
        {
            Model = model;
            Id = id;
        }
        public string Model { get; }
        public string Id { get; }
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
