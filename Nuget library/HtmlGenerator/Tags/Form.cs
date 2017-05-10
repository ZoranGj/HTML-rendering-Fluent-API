using HtmlGenerator.FluentAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlGenerator.Tags
{
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
