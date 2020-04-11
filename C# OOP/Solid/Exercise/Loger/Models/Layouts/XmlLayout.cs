using System;
using System.Collections.Generic;
using System.Text;
using Loger.Models.Contracts;

namespace Loger.Models.Layouts
{
    public class XmlLayout : ILayout
    {
        public string Format => this.GetDataFormat();

        private string GetDataFormat()
        {
            var sb = new StringBuilder();
            sb  
                .AppendLine("<log>")
                 .AppendLine("<data>{0}</date>")
                 .AppendLine("<level>{1}</level>")
                 .AppendLine("<message>{2}</message>")
                .AppendLine("</log>");
            return sb.ToString().TrimEnd();
        }
    }
}
