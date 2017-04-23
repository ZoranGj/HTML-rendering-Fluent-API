using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Controls
{
    public class Input : Control
    {
        private Property _property;

        public string InputType
        {
            get
            {
                if (_property == null)
                    return "text";

                switch (_property.Type)
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

        public Input(Property property)
        {
            _property = property;
        }

        public Input() { }

        public override string Html()
        {
            return string.Format("{0}<input type='{1}' {2} />{0}", Environment.NewLine, InputType, Attribures());
        }
    }
}
