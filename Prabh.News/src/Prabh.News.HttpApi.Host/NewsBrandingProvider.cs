using Microsoft.Extensions.Localization;
using Prabh.News.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Prabh.News;

[Dependency(ReplaceServices = true)]
public class NewsBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<NewsResource> _localizer;

    public NewsBrandingProvider(IStringLocalizer<NewsResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
