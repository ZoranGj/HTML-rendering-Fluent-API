using Domain;
using System;

namespace API.Controls
{
    public class Input : Control
    {
        public PropertyDefinition Definition { get; set; }

        public string InputType
        {
            get
            {
                if (Definition == null)
                    return "text";

                switch (Definition.Type)
                {
                    case PropertyType.Boolean:
                        return "checkbox";
                    case PropertyType.Date:
                        return "date";
                    case PropertyType.DateTime:
                        return "datetime";
                    default:
                        return "text";
                }
            }
        }

        public Input() { }

        public override string Html()
        {
            return string.Format("{0}<input type='{1}' {2} {3}/>{0}", Environment.NewLine, InputType, GenerateAttributes(), GenerateStyles());
        }
    }
}
