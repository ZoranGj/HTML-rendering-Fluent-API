using HtmlGenerator.FluentAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlGenerator.Controls
{
    public class Body : Control
    {
        public override string Html()
        {
            var stringBuilder = new StringBuilder("<body>");
            stringBuilder.ChildrenHTML(this);
            stringBuilder.Append("</body>");
            return stringBuilder.ToString();
        }
    }
}