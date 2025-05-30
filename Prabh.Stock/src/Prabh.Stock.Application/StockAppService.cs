using Prabh.Stock.Localization;
using Volo.Abp.Application.Services;

namespace Prabh.Stock;

/* Inherit your application services from this class.
 */
public abstract class StockAppService : ApplicationService
{
    protected StockAppService()
    {
        LocalizationResource = typeof(StockResource);
    }
}
