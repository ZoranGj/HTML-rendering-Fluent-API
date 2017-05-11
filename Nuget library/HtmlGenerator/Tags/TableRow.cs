using System;
using System.Text;
using System.Collections.Generic;

namespace HtmlGenerator.Tags
{
    /// <summary>
    /// Tag which represents <tr> HTML element.
    /// </summary>
    public class TableRow : Tag
    {
        public List<string> Values { get; set; }

        public override string Html()
        {
            var stringBuilder = new StringBuilder(Environment.NewLine);
            stringBuilder.Append("<tr>");
            Values.ForEach(v => stringBuilder.Append(TableCellHtml(v)));
            stringBuilder.Append("</tr>").Append(Environment.NewLine);
            return stringBuilder.ToString();
        }

        private string TableCellHtml(string value)
        {
            return string.Format("<td>{0}</td>", value);
        }
    }
}
