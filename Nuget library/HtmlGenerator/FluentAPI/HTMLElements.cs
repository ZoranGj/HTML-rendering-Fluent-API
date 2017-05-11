using System.Collections.Generic;
using System.Linq;
using HtmlGenerator.Tags;

namespace HtmlGenerator.FluentAPI
{
    /// <summary>
    /// Fluent API for building html with adding elements, attributes, 
    /// styles on the Tag element.
    /// </summary>
    public static class HTMLElements
    {
        /// <summary>
        /// Adds list of tags as children to a tag.
        /// </summary>
        /// <param name="tag">The source tag.</param>
        /// <param name="elements">List of elements added as children.</param>
        /// <returns>Tag with children tags.</returns>
        public static Tag Elements(this Tag tag, params Tag[] elements)
        {
            tag.Children = elements.ToList();
            return tag;
        }

        /// <summary>
        /// Adds tag as child to a tag.
        /// </summary>
        /// <param name="tag">The source tag.</param>
        /// <param name="element">Element added as a child.</param>
        /// <returns>Tag with child tag.</returns>
        public static Tag Element(this Tag tag, Tag element)
        {
            tag.Children = new List<Tag> { element };
            return tag;
        }
    }
}