using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Entity
    {
        public int Id { get; set; }
        public EntityDefinition Definition { get; set; }
        public HashSet<Property> Properties { get; set; }
    }
}
