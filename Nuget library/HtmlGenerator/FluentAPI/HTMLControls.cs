using HtmlGenerator.Tags;
using HtmlGenerator.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlGenerator.FluentAPI
{
    public static class HTMLControls
    {
        public static Tag Elements(this Tag tag, params Tag[] elements)
        {
            tag.Children = elements.ToList();
            return tag;
        }

        public static Tag Element(this Tag tag, Tag element)
        {
            tag.Children = new List<Tag> { element };
            return tag;
        }

        public static Tag Attribute(this Tag tag, string attribute, string value)
        {
            if (!string.IsNullOrEmpty(attribute))
            {
                tag.Attributes.Add(attribute, value);
            }
            return tag;
        }

        public static Tag Class(this Tag tag, string value)
        {
            tag.Attributes.Add("class", value);
            return tag;
        }

        public static Tag Style(this Tag tag, string attr, string value)
        {
            tag.Styles.AddStyle(attr, value);
            return tag;
        }

        public static Tag Data(this Tag tag, string dataSuffix, string value)
        {
            tag.Attributes.Add(string.Format("data-{0}", dataSuffix), value);
            return tag;
        }
    }
}