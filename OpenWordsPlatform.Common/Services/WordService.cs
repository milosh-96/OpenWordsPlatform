using OpenWordsPlatform.Common.Constants;
using OrchardCore.ContentManagement;

namespace OpenWordsPlatform.Common.Services;

public static class WordService
{
    public static string? GetDefaultArticle(ContentItem item)
    {
        string? definiteArticle = null;
        foreach (var widget in item.Content.FlowPart.Widgets)
        {
            if (widget["ContentType"] == ContentTypes.ArticlesWidget)
            {
                definiteArticle = widget["ArticlesPart"]["DefiniteSingular"]["Text"];
            }
        }
        return definiteArticle;
    }
    public static string? GetWordWithDefaultArticle(ContentItem item)
    {
        string? definiteArticle = null;
        foreach (var widget in item.Content.FlowPart.Widgets)
        {
            if (widget["ContentType"] == ContentTypes.ArticlesWidget)
            {
                definiteArticle = widget["ArticlesPart"]["DefiniteSingular"]["Text"] + " ";
            }
        }
        return definiteArticle + item.DisplayText;
    }
    public static string? GetPluralFormOfWordWithArticle(ContentItem item)
    {
        string? article = null;
        string? completeWord = null;
        if(item.Content.Word.PluralForm.Text != null)
        {
            foreach (var widget in item.Content.FlowPart.Widgets)
            {
                if (widget["ContentType"] == ContentTypes.ArticlesWidget)
                {
                    article = widget["ArticlesPart"]["DefinitePlural"]["Text"] + " ";
                }
            }
            completeWord = article + item.Content.Word.PluralForm.Text;
        }
        return completeWord;
    }
}
