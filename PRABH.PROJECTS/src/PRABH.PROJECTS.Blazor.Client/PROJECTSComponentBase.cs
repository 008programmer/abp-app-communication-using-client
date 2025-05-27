using PRABH.PROJECTS.Localization;
using Volo.Abp.AspNetCore.Components;

namespace PRABH.PROJECTS.Blazor.Client;

public abstract class PROJECTSComponentBase : AbpComponentBase
{
    protected PROJECTSComponentBase()
    {
        LocalizationResource = typeof(PROJECTSResource);
    }
}
