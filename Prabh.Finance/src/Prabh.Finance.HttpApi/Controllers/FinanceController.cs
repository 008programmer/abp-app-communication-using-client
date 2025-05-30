using Prabh.Finance.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Prabh.Finance.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class FinanceController : AbpControllerBase
{
    protected FinanceController()
    {
        LocalizationResource = typeof(FinanceResource);
    }
}
