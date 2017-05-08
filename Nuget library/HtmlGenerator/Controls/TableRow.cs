using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlGenerator.Controls
{
    public class TableRow : Control
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
