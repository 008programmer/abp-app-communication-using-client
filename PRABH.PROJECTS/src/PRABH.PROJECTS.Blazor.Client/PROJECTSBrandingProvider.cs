using Microsoft.Extensions.Localization;
using PRABH.PROJECTS.Localization;
using Microsoft.Extensions.Localization;
using PRABH.PROJECTS.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace PRABH.PROJECTS.Blazor.Client;

[Dependency(ReplaceServices = true)]
public class PROJECTSBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<PROJECTSResource> _localizer;

    public PROJECTSBrandingProvider(IStringLocalizer<PROJECTSResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
