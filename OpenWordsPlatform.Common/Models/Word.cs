using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;
using OrchardCore.Taxonomies.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWordsPlatform.Common.Models
{
    public class Word : ContentPart
    {
        public TaxonomyField GenderTaxonomy { get; set; } = new();
    }
}
