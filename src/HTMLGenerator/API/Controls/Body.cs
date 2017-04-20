using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Controls
{
    public class Body : Control
    {
        public override string Html()
        {
            var stringBuilder = "<body>";
            foreach (var child in Children)
            {
                stringBuilder += child.Html();
            }
            stringBuilder += "</body>";
            return stringBuilder.ToString();
        }
    }
}
