using HtmlGenerator.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlGenerator.FluentAPI
{
    public static class HTMLGeneration
    {
        public static void ChildrenHTML(this StringBuilder stringBuilder, Tag tag)
        {
            foreach (var child in tag.Children)
            {
                stringBuilder.Append(child.Html());
            }
        }
    }
}
