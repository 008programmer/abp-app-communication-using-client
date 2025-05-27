using PRABH.PEOPLE.Localization;
using Volo.Abp.Application.Services;

namespace PRABH.PEOPLE;

/* Inherit your application services from this class.
 */
public abstract class PEOPLEAppService : ApplicationService
{
    protected PEOPLEAppService()
    {
        LocalizationResource = typeof(PEOPLEResource);
    }
}
