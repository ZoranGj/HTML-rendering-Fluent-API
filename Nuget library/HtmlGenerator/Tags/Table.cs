using System;
using System.Text;
using HtmlGenerator.FluentAPI;

namespace HtmlGenerator.Tags
{
    /// <summary>
    /// Tag which represents <table> HTML element.
    /// </summary>
    public class Table : Tag
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
