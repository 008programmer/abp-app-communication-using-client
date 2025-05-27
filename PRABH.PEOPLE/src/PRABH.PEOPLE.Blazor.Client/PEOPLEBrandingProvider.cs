using Microsoft.Extensions.Localization;
using PRABH.PEOPLE.Localization;
using Microsoft.Extensions.Localization;
using PRABH.PEOPLE.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace PRABH.PEOPLE.Blazor.Client;

[Dependency(ReplaceServices = true)]
public class PEOPLEBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<PEOPLEResource> _localizer;

    public PEOPLEBrandingProvider(IStringLocalizer<PEOPLEResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
