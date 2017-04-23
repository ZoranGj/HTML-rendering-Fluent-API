using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Controls
{
    public class Container : Control
    {
        public override string Html()
        {
            var stringBuilder = new StringBuilder(Environment.NewLine);
            stringBuilder.Append(string.Format("<div{0}>", Attribures()));
            foreach (var child in Children)
            {
                stringBuilder.Append(child.Html());
            }
            stringBuilder.Append("</div>").Append(Environment.NewLine);
            return stringBuilder.ToString();
        }
    }
}
