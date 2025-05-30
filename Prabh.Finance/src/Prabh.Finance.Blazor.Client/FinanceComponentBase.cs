using Prabh.Finance.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Prabh.Finance.Blazor.Client;

public abstract class FinanceComponentBase : AbpComponentBase
{
    protected FinanceComponentBase()
    {
        LocalizationResource = typeof(FinanceResource);
    }
}
