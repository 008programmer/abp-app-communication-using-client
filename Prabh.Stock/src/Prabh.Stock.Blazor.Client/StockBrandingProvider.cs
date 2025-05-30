using Microsoft.Extensions.Localization;
using Prabh.Stock.Localization;
using Microsoft.Extensions.Localization;
using Prabh.Stock.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Prabh.Stock.Blazor.Client;

[Dependency(ReplaceServices = true)]
public class StockBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<StockResource> _localizer;

    public StockBrandingProvider(IStringLocalizer<StockResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
