 using System;
using System.Collections.Generic;
 using System.Data;
 using System.Text;
 using Loger.Models.Contracts;
 using Loger.Models.Layouts;

 namespace Loger.Factories
{
  public  class LayoutFactory
    {
        public ILayout ProduceLayout(string type)
        {
            ILayout layout;
            if (type == "SimpleLayout")
            {
                layout = new SimpleLayouts();
            }
            else if (type == "XmlLayout")
            {
                layout = new XmlLayout();
            }
            else
            {
                throw new ArgumentException("Invalid layout");
            }

            return layout;  
        }
    }
}
