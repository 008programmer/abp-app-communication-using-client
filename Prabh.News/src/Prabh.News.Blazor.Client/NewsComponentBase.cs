using Prabh.News.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Prabh.News.Blazor.Client;

public abstract class NewsComponentBase : AbpComponentBase
{
    protected NewsComponentBase()
    {
        LocalizationResource = typeof(NewsResource);
    }
}
