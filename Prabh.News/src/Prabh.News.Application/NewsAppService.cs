using Prabh.News.Localization;
using Volo.Abp.Application.Services;

namespace Prabh.News;

/* Inherit your application services from this class.
 */
public abstract class NewsAppService : ApplicationService
{
    protected NewsAppService()
    {
        LocalizationResource = typeof(NewsResource);
    }
}
