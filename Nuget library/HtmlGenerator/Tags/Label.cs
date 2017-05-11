using System;

namespace HtmlGenerator.Tags
{
    /// <summary>
    /// Tag which represents <label> HTML element.
    /// </summary>
    public class Label : Tag
    {
        public string Text { get; set; }

        public override string Html()
        {
            return string.Format("{0}<label {2}>{1}</label>{0}", Environment.NewLine, Text, GenerateStyles());
        }
    }
}
