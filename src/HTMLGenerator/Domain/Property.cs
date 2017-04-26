using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Property
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public PropertyType Type { get; set; }
        public PropertyDefinition Definition { get; set; }
    }
}
