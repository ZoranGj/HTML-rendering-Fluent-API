using HtmlGenerator.Tags;

namespace HtmlGenerator.FluentAPI
{
    /// <summary>
    /// Fluent API for decorating Tag element with attributes, styles, css classes
    /// </summary>
    public static class HTMLAttributes
    {
        /// <summary>
        /// Adds html attribute with specific value to a tag.
        /// </summary>
        /// <param name="tag">The source tag.</param>
        /// <param name="attribute">The attribute name.</param>
        /// <param name="value">The attribute value.</param>
        /// <returns>Tag with added attribute.</returns>
        public static Tag Attribute(this Tag tag, string attribute, string value)
        {
            if (!string.IsNullOrEmpty(attribute))
            {
                tag.Attributes.Add(attribute, value);
            }
            return tag;
        }

        /// <summary>
        /// Adds css class to a tag.
        /// </summary>
        /// <param name="tag">The source tag.</param>
        /// <param name="value">The css class.</param>
        /// <returns>Tag with added css class.</returns>
        public static Tag Class(this Tag tag, string value)
        {
            tag.Attributes.Add("class", value);
            return tag;
        }

        /// <summary>
        /// Appends css style to a tag.
        /// </summary>
        /// <param name="tag">The source tag.</param>
        /// <param name="attr">The style name.</param>
        /// <param name="value">The style value.</param>
        /// <returns>Tag with added css style.</returns>
        public static Tag Style(this Tag tag, string attr, string value)
        {
            tag.Styles.AddStyle(attr, value);
            return tag;
        }

        /// <summary>
        /// Adds color to tag.
        /// </summary>
        /// <param name="tag">The source tag.</param>
        /// <param name="color">The specified color.</param>
        /// <returns>Tag with added color style.</returns>
        public static Tag Color(this Tag tag, string color)
        {
            tag.Styles.AddStyle("color", color);
            return tag;
        }

        /// <summary>
        /// Adds background to tag (specific color or image url).
        /// </summary>
        /// <param name="tag">The source tag.</param>
        /// <param name="bg">The background value.</param>
        /// <returns>Tag with added background style.</returns>
        public static Tag Background(this Tag tag, string bg)
        {
            tag.Styles.AddStyle("background", bg);
            return tag;
        }

        /// <summary>
        /// Adds font size style to tag.
        /// </summary>
        /// <param name="tag">The source tag.</param>
        /// <param name="font">The font size.</param>
        /// <returns>Tag with added font size style.</returns>
        public static Tag Font(this Tag tag, int font)
        {
            if (font <= 0) return tag;
            tag.Styles.AddStyle("font-size", string.Format("{0}px", font.ToString()));
            return tag;
        }

        /// <summary>
        /// Adds new data attribute to a tag.
        /// </summary>
        /// <param name="tag">The source tag.</param>
        /// <param name="dataSuffix">Data suffix.</param>
        /// <param name="value">The attribute value.</param>
        /// <returns>Tag with added data attribute.</returns>
        public static Tag Data(this Tag tag, string dataSuffix, string value)
        {
            tag.Attributes.Add(string.Format("data-{0}", dataSuffix), value);
            return tag;
        }

        /// <summary>
        /// Adds placeholder to a Input tag.
        /// </summary>
        /// <param name="tag">The source input tag.</param>
        /// <param name="placeholder">The placeholder.</param>
        /// <returns>Input tag with a placeholder.</returns>
        public static Tag Placeholder(this Tag tag, string placeholder)
        {
            if (tag.GetType() != typeof(Input))
            {
                return tag;
            }

            (tag as Input).Placeholder = placeholder;
            return tag;
        }
    }
}
