using HtmlGenerator.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlGenerator.Tags
{
    public abstract class Tag : IHTMLElement
    {
        public List<Tag> Children { get; set; }
        public Dictionary<string, string> Attributes { get; set; }
        public Dictionary<string, string> Styles { get; set; }

        public abstract string Html();

        public Tag()
        {
            Attributes = new Dictionary<string, string>();
            Styles = new Dictionary<string, string>();
        }

        public string GenerateAttributes()
        {
            var stringBuilder = new StringBuilder();
            foreach(var elem in Attributes)
            {
                stringBuilder.Append(string.Format(" {0}='{1}'", elem.Key, elem.Value));
            }

            return stringBuilder.ToString();
        }

        public string GenerateStyles()
        {
            var stringBuilder = new StringBuilder(" style='");
            foreach (var elem in Attributes)
            {
                stringBuilder.Append(string.Format(" {0}='{1}'", elem.Key, elem.Value));
            }

            stringBuilder.Append("'");
            return stringBuilder.ToString();
        }
    }
}
