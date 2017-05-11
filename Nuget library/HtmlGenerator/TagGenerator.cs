using HtmlGenerator.Tags;

namespace HtmlGenerator
{
    /// <summary>
    /// Class for creating HTML tag elements.
    /// </summary>
    public class TagGenerator
    {
        /// <summary>
        /// Creates a Form tag.
        /// </summary>
        /// <returns>Form tag.</returns>
        public static Tag Form()
        {
            return new Form();
        }

        /// <summary>
        /// Creates a Label tag.
        /// </summary>
        /// <param name="text">Label text.</param>
        /// <returns>Label tag.</returns>
        public static Tag Label(string text)
        {
            var label = new Label();
            label.Text = text;
            return label;
        }

        /// <summary>
        /// Creates a Body tag.
        /// </summary>
        /// <returns>Body tag.</returns>
        public static Tag Body()
        {
            return new Body();
        }

        /// <summary>
        /// Creates a Container tag.
        /// </summary>
        /// <returns>Container tag.</returns>
        public static Tag Container()
        {
            return new Container();
        }

        /// <summary>
        /// Creates an Input tag.
        /// </summary>
        /// <returns>Input tag.</returns>
        public static Tag Input()
        {
            var input = new Input();
            input.InputType = "text";
            return input;
        }

        /// <summary>
        /// Creates a Table tag.
        /// </summary>
        /// <returns>Table tag.</returns>
        public static Table Table()
        {
            return new Table();
        }
    }
}
