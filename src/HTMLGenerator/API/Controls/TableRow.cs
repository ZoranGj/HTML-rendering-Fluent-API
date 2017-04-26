using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Controls
{
    public class TableRow : Control
    {
        public Entity Entity { get; set; }

        public override string Html()
        {
            throw new NotImplementedException();
        }
    }
}
