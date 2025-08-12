
using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;

namespace OpenWordsPlatform.Common.Models;

public class ConjugationPart : ContentPart
{
    public TextField Note { get; set; } = new();
    public BooleanField IsRegular { get; set; } = new();
    public TextField FirstSingular { get; set; } = new();
    public TextField SecondSingular { get; set; } = new();
    public TextField ThirdSingular { get; set; } = new();
    public TextField FirstPlural { get; set; } = new();
    public TextField SecondPlural { get; set; } = new();
    public TextField ThirdPlural { get; set; } = new();
}
