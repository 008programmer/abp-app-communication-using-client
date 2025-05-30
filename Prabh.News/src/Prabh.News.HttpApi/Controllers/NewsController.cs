using Prabh.News.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Prabh.News.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class NewsController : AbpControllerBase
{
    protected NewsController()
    {
        LocalizationResource = typeof(NewsResource);
    }
}
