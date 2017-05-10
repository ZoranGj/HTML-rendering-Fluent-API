using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlGenerator.Tags
{
    public class Label : Tag
    {
        public string Text { get; set; }

        public override string Html()
        {
            return string.Format("{0}<label>{1}</label>{0}", Environment.NewLine, Text);
        }
    }
}
