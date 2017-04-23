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
        public string ExampleForm()
        {
            var html = 
            Form().Elements(Container().Class("well").Style("padding: 20px;").Elements(
                Label("Form label"),
                Container().Class("col-md-6").Elements(
                        Container().Class("form-group").Elements(
                            Label("Input 1"),
                            Input().Class("form-control"),
                            Label("Input 2"),
                            Input().Class("form-control")),
                        Label("Input 3"),
                        Input().Class("form-control")),
                Container().Class("col-md-6 form-group").Elements(
                        Label("Input 4"),
                        Input().Class("form-control"))));
            return html.Html();
        }

        public string ExampleMultipleForms()
        {
            var html = 
                Container().Elements(
                    Form().Elements(
                        Container().Elements(
                            Label("Input 1"),
                            Input().Class("form-control")),
                        Container().Elements(
                            Label("Input 2"),
                            Input().Class("form-control")),
                        Container().Elements(
                            Label("Input 3"),
                            Input().Class("form-control")),
                        Container().Elements(
                            Label("Input 4"),
                            Input().Class("form-control")),
                        Container().Elements(
                            Container().Elements(
                                Label("Input 5"),
                                Input().Class("form-control"),
                                Label("Input 6"),
                                Input().Class("form-control")))),
                    Form().Elements(
                        Container().Elements(
                            Label("Input 1"),
                            Input().Class("form-control")),
                        Label("Input 2"),
                        Input().Class("form-control"),
                        Label("Input 3"),
                        Input().Class("form-control"))
                );
            return html.Html();
        }

        public static Control Form()
        {
            return new Form();
        }

        public static Control Label(string text)
        {
            return new Label(text);
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
