using System;
using System.Collections.Generic;
using System.Text;
using Loger.Models.Contracts;

namespace Loger.Models.Layouts
{
    public class SimpleLayouts : ILayout
    {
        public string Format => "{0} - {1} - {2}";

    }

}
