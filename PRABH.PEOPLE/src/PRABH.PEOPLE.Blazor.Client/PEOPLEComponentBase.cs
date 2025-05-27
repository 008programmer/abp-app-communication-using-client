using PRABH.PEOPLE.Localization;
using Volo.Abp.AspNetCore.Components;

namespace PRABH.PEOPLE.Blazor.Client;

public abstract class PEOPLEComponentBase : AbpComponentBase
{
    protected PEOPLEComponentBase()
    {
        LocalizationResource = typeof(PEOPLEResource);
    }
}
