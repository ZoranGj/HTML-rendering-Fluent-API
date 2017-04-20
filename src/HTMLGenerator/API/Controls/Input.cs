using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Controls
{
    public class Input : Control
    {
        public override string Html()
        {
            return string.Format("{0}<input type='text' />{0}", Environment.NewLine);
        }
    }
}
