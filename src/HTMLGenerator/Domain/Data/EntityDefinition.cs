using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class EntityDefinition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public HashSet<PropertyDefinition> PropertyDefinitions { get; set; }
    }
}