using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Controls
{
    public class Label : Control
    {
        private readonly string _text;

        public Label(string text)
        {
            _text = text;
        }

        public override string Html()
        {
            return string.Format("{0}<label>{1}</label>{0}", Environment.NewLine, _text);
        }
    }
}
