using Prabh.Stock.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Prabh.Stock.Blazor.Client;

public abstract class StockComponentBase : AbpComponentBase
{
    protected StockComponentBase()
    {
        LocalizationResource = typeof(StockResource);
    }
}
