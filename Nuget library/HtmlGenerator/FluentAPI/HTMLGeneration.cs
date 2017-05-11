using System.Collections.Generic;
using System.Text;
using HtmlGenerator.Tags;

namespace HtmlGenerator.FluentAPI
{
    /// <summary>
    /// Extension methods for generating HTML
    /// </summary>
    public static class HTMLGeneration
    {
        /// <summary>
        /// Converts the child tags of a tag to HTML and appends them to the HTML source.
        /// </summary>
        /// <param name="stringBuilder">The HTML source</param>
        /// <param name="tag">The source tag.</param>
        public static void ChildrenHTML(this StringBuilder stringBuilder, Tag tag)
        {
            foreach (var child in tag.Children)
            {
                stringBuilder.Append(child.Html());
            }
        }

        /// <summary>
        /// Adds or appends new style to the list of styles of a tag.
        /// </summary>
        /// <param name="styles">The list of styles.</param>
        /// <param name="attr">The style name.</param>
        /// <param name="value">The style value.</param>
        public static void AddStyle(this Dictionary<string, string> styles, string attr, string value)
        {
            if (styles.ContainsKey(attr))
            {
                styles[attr] = value;
            }
            else
            {
                styles.Add(attr, value);
            }
        }
    }
}
