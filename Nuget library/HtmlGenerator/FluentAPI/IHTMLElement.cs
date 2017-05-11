
namespace HtmlGenerator.Infrastructure
{
    public interface IHTMLElement
    {
        string GenerateAttributes();

        string GenerateStyles();
    }
}
