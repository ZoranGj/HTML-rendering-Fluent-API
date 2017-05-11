using System.Text;
using HtmlGenerator.FluentAPI;

namespace HtmlGenerator.Tags
{
    /// <summary>
    /// Tag which represents <form> HTML element.
    /// </summary>
    public class Form : Tag
    {
        public override string Html()
        {
            var stringBuilder = new StringBuilder("<form>");
            stringBuilder.ChildrenHTML(this);
            stringBuilder.Append("</form>");
            return stringBuilder.ToString();
        }
    }
}
