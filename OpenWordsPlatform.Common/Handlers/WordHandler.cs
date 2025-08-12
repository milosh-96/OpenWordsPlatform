using OpenWordsPlatform.Common.Constants;
using OpenWordsPlatform.Common.Models;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWordsPlatform.Common.Handlers
{
    public class WordHandler : ContentPartHandler<Word>
    {
        public override Task UpdatedAsync(UpdateContentContext context, Word part) =>
        Task.Run(() =>
        {
            string gender = part.Content.Gender.Text == GenderTypes.None ? string.Empty : part.Content.Gender.Text;
            context.ContentItem.Content.TitlePart.Title = string.IsNullOrEmpty(gender) ? part.Content.Name.Text : gender + " " + part.Content.Name.Text;
            context.ContentItem.DisplayText = context.ContentItem.Content.TitlePart.Title;
        });
    }
}
