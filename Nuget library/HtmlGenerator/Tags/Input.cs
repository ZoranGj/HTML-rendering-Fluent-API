using System;

namespace HtmlGenerator.Tags
{
    /// <summary>
    /// Tag which represents <input> HTML element.
    /// </summary>
    public class Input : Tag
    {
        public string InputType { get; set; }

        public string Placeholder { get; set; }

        public override string Html()
        {
            return string.Format("{0}<input type='{1}' {2} {3} placeholder='{4}'/>{0}", Environment.NewLine, InputType, GenerateAttributes(), GenerateStyles(), Placeholder);
        }
    }
}
