using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using API.FluentAPI;
using API.Controls;

namespace API
{
    public class Engine
    {
        public string Generate()
        {
            var html = Body().Elements(
                Container().Elements(
                        Container().Elements(
                            Input(),
                            Input()),
                        Input()),
                Container().Elements(
                        Input()));
            return html.Html();
        }

        public static Control Body()
        {
            return new Body();
        }

        public static Container Container()
        {
            return new Container();
        }

        public static Input Input()
        {
            return new Input();
        }
    }
}
