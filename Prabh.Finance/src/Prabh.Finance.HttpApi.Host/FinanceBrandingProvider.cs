using Microsoft.Extensions.Localization;
using Prabh.Finance.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Prabh.Finance;

[Dependency(ReplaceServices = true)]
public class FinanceBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<FinanceResource> _localizer;

    public FinanceBrandingProvider(IStringLocalizer<FinanceResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
