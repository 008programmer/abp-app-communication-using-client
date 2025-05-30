using Prabh.Stock.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Prabh.Stock.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class StockController : AbpControllerBase
{
    protected StockController()
    {
        LocalizationResource = typeof(StockResource);
    }
}
