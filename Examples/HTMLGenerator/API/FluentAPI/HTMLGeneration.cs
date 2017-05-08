using API.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.FluentAPI
{
    public static class HTMLGeneration
    {
        public static void ChildrenHTML(this StringBuilder stringBuilder, Control control)
        {
            foreach (var child in control.Children)
            {
                stringBuilder.Append(child.Html());
            }
        }
    }
}
