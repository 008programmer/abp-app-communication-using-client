using PRABH.PEOPLE.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PRABH.PEOPLE.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class PEOPLEController : AbpControllerBase
{
    protected PEOPLEController()
    {
        LocalizationResource = typeof(PEOPLEResource);
    }
}
