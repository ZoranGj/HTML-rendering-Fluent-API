using HtmlGenerator.FluentAPI;
using HtmlGenerator.Tags;

namespace HtmlGenerator.Infrastructure
{
    public class TagGenerator
    {
        public static Tag Form()
        {
            return new Form();
        }

        public static Tag Label(string text)
        {
            var label = new Label();
            label.Text = text;
            return label;
        }

        public static Tag Body()
        {
            return new Body();
        }

        public static Tag Container()
        {
            return new Container();
        }

        public static Tag Input()
        {
            return new Input();
        }

        public static Table Table()
        {
            return new Table();
        }
    }
}
