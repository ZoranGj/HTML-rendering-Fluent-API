using System.Text;
using HtmlGenerator.FluentAPI;

namespace HtmlGenerator.Tags
{
    /// <summary>
    /// Tag which represents <body> HTML element.
    /// </summary>
    public class Body : Tag
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