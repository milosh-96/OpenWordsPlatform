using OpenWordsPlatform.Common.Constants;
using OpenWordsPlatform.Common.Models;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrchardCore.Taxonomies.Services;
using YesSql;
using OrchardCore;

namespace OpenWordsPlatform.Common.Handlers;

public class WordHandler : ContentPartHandler<Word>
{
    private readonly IOrchardHelper  _orchardHelper;

    public WordHandler(IOrchardHelper orchardHelper)
    {
        _orchardHelper = orchardHelper;
    }
    
    public override async Task UpdatedAsync(UpdateContentContext context, Word part) {
        ContentItem gender = await _orchardHelper.GetTaxonomyTermAsync(part.GenderTaxonomy.TaxonomyContentItemId, part.GenderTaxonomy.TermContentItemIds[0]);
        context.ContentItem.Content.TitlePart.Title = gender == null ? part.Content.Name.Text : SetArticle(gender) + part.Content.Name.Text;
        context.ContentItem.DisplayText = context.ContentItem.Content.TitlePart.Title;
    }

    private string SetArticle(ContentItem gender)
    {
        if(gender.DisplayText == GenderTypes.None)
        {
            return string.Empty;
        }
        return gender.Content.Gender.DefiniteArticle.Text + " ";
    }
}
