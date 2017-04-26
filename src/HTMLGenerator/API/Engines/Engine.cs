using API.FluentAPI;
using API.Controls;

namespace API.Engine
{
    public class Engine
    {
        public string ExampleForm()
        {
            var html = 
            Form().Elements(Container().Class("well").Style("padding", "20px;").Elements(
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

        protected static Control Form()
        {
            return new Form();
        }

        protected static Control Label(string text)
        {
            return new Label(text);
        }

        protected static Control Body()
        {
            return new Body();
        }

        protected static Control Container()
        {
            return new Container();
        }

        protected static Control Input()
        {
            return new Input();
        }

        protected static Table Table()
        {
            return new Table();
        }
    }
}
