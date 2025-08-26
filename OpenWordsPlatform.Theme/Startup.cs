using Microsoft.Extensions.DependencyInjection;
using OpenWordsPlatform.Theme.Constants;
using OrchardCore.Modules;

namespace OpenWordsPlatform.Theme;

public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        // This shortcut is added by Lombiq.HelpfulLibraries.OrchardCore.
        services.AddResourceManagementConfiguration<ResourceManagementOptionsConfiguration>();

        // This creates an anonymous service that provides configuration to the ResourceFilterMiddleware (which is added
        // by Lombiq.BaseTheme.Core).
        services.AddResourceFilter(
            builder =>
            {
                builder.Always().RegisterStylesheet(ResourceNames.Site);
            },
            FeatureIds.OpenWordsPlatformTheme);

        // Note that some related features, like frontend navigation providers and admin-side favicon configuration, are
        // not demonstrated here. Check out the non-Sass demos in Lombiq.BaseTheme.Samples project as well.
    }
}
