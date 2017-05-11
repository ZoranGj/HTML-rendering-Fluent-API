using System;
using System.Text;
using HtmlGenerator.FluentAPI;

namespace HtmlGenerator.Tags
{
    /// <summary>
    /// Tag which represents <div> HTML element.
    /// </summary>
    public class Container : Tag
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
