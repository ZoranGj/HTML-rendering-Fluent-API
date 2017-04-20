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
            var stringBuilder = Environment.NewLine;
            stringBuilder += "<div>";
            foreach (var child in Children)
            {
                stringBuilder += child.Html();
            }
            stringBuilder += "</div>";
            stringBuilder += Environment.NewLine;
            return stringBuilder.ToString();
        }
    }
}
