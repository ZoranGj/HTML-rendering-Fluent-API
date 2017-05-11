using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlGenerator.FluentAPI;
using static HtmlGenerator.TagGenerator;

namespace Domain
{
    public class Engine
    {
        public string ExampleForm()
        {
            var html =
            Form().Elements(Container().Class("well").Style("padding", "20px;").Background("#f2f2f2").Elements(
                Container().Class("col-md-12").Elements(
                        Label("Form label").Style("margin-bottom", "12px;").Font(24)),
                Container().Class("col-md-6").Elements(
                        Container().Class("form-group").Elements(
                            Label("Input 1"),
                            Input().Class("form-control").Placeholder("Input 1..."),
                            Label("Input 2"),
                            Input().Class("form-control").Placeholder("Input 2...")),
                        Label("Input 3").Color("green"),
                        Input().Class("form-control").Placeholder("Input 3...")),
                Container().Class("col-md-6 form-group").Elements(
                        Label("Input 4").Color("green"),
                        Input().Class("form-control").Placeholder("Input 4..."))));
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
    }
}
