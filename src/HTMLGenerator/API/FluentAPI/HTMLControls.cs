using API.Controls;
using API.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.FluentAPI
{
    public static class HTMLControls
    {
        public static Control Elements(this Control control, params Control[] elements)
        {
            control.Children = elements.ToList();
            return control;
        }

        public static Control Element(this Control control, Control element)
        {
            control.Children = new List<Control> { element };
            return control;
        }

        public static Control Attribute(this Control control, string attribute, string value)
        {
            if (!string.IsNullOrEmpty(attribute))
            {
                control.Attributes.Add(attribute, value);
            }
            return control;
        }

        public static Control Class(this Control control, string value)
        {
            control.Attributes.Add("class", value);
            return control;
        }

        public static Control Style(this Control control, string attr, string value)
        {
            control.Styles.AddStyle(attr, value);
            return control;
        }
    }
}
