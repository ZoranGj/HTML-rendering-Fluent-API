using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlGenerator.Infrastructure;

namespace HtmlGenerator.Tags
{
    /// <summary>
    /// Class that represents an HTML element.
    /// </summary>
    public abstract class Tag : IHTMLElement
    {
        public List<Tag> Children { get; set; }
        public Dictionary<string, string> Attributes { get; set; }
        public Dictionary<string, string> Styles { get; set; }

        /// <summary>
        /// Renders the Tag as a HTML string.
        /// </summary>
        /// <returns>HTML string.</returns>
        public abstract string Html();

        public Tag()
        {
            Attributes = new Dictionary<string, string>();
            Styles = new Dictionary<string, string>();
        }

        /// <summary>
        /// Generates the tag attributes as a string.
        /// </summary>
        /// <returns>String with generated attributes.</returns>
        public string GenerateAttributes()
        {
            var stringBuilder = new StringBuilder();
            foreach(var elem in Attributes)
            {
                stringBuilder.Append(string.Format(" {0}='{1}'", elem.Key, elem.Value));
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Generates the tag styles as a string.
        /// </summary>
        /// <returns>String with generated styles.</returns>
        public string GenerateStyles()
        {
            if (!Styles.Any())
            {
                return string.Empty;
            }

            var stringBuilder = new StringBuilder(" style='");
            foreach (var elem in Styles)
            {
                stringBuilder.Append(string.Format("{0}: {1}", elem.Key, elem.Value));
            }

            stringBuilder.Append("'");
            return stringBuilder.ToString();
        }
    }
}
