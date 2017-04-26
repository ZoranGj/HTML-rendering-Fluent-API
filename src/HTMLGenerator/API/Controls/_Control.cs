using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Controls
{
    public abstract class Control
    {
        public List<Control> Children { get; set; }
        public Dictionary<string, string> Attributes { get; set; }
        public Dictionary<string, string> Styles { get; set; }

        public abstract string Html();

        public Control()
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
