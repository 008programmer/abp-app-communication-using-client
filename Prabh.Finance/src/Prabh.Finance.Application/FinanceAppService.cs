using Prabh.Finance.Localization;
using Volo.Abp.Application.Services;

namespace Prabh.Finance;

/* Inherit your application services from this class.
 */
public abstract class FinanceAppService : ApplicationService
{
    protected FinanceAppService()
    {
        LocalizationResource = typeof(FinanceResource);
    }
}
