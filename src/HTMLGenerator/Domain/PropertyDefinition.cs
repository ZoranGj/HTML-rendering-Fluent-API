using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class PropertyDefinition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PropertyType Type { get; set; }
    }
}
