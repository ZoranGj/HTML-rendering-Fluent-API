using HtmlGenerator.FluentAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlGenerator.Controls
{
    public class Table : Control
    {
        public override string Html()
        {
            var stringBuilder = new StringBuilder(Environment.NewLine);
            stringBuilder.Append(string.Format("<table{0} {1}>", GenerateAttributes(), GenerateStyles()));
            stringBuilder.ChildrenHTML(this);
            stringBuilder.Append("</table>").Append(Environment.NewLine);
            return stringBuilder.ToString();
        }
    }
}
