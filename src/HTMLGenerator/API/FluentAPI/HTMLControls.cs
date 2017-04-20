using API.Controls;
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
    }
}
