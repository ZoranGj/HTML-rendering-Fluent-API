using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Controls
{
    public abstract class Control
    {
        public List<Control> Children { get; set; }
        public abstract string Html();
    }
}
