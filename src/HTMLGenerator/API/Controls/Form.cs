using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Controls
{
    public class Form : Control
    {
        public override string Html()
        {
            var stringBuilder = new StringBuilder("<form>");
            foreach (var child in Children)
            {
                stringBuilder.Append(child.Html());
            }
            stringBuilder.Append("</form>");
            return stringBuilder.ToString();
        }
    }
}
