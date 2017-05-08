using HtmlGenerator.FluentAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlGenerator.Controls
{
    public class Container : Control
    {
        public override string Html()
        {
            var stringBuilder = new StringBuilder(Environment.NewLine);
            stringBuilder.Append(string.Format("<div{0} {1}>", GenerateAttributes(), GenerateStyles()));
            stringBuilder.ChildrenHTML(this);
            stringBuilder.Append("</div>").Append(Environment.NewLine);
            return stringBuilder.ToString();
        }
    }
}
